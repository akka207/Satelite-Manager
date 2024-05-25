using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ekzamen
{
    public enum Mode { Temperature, Radiation }
    public enum State { Empty, Running, Stopped, Error }
    public enum EmergencyType { Null, ExternalObjectHit, Overheating, SystemError }
    public enum SatelliteType { GPS, Internet, Telescope }


    public class SatelliteInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public SatelliteType SatelliteType { get; set; }
        public float OrbitPosition { get; set; }
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }
        public float D { get; set; }

        public SatelliteInfo(string id, string name, SatelliteType satelliteType, float orbitFuncPosition, float a, float b, float c, float d)
        {
            Id = id;
            Name = name;
            SatelliteType = satelliteType;
            OrbitPosition = orbitFuncPosition;
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }

    public class Satellite
    {
        public string ID;
        public string Name;
        public SatelliteType SatelliteType;
        public Func<float, float, float, float, float, float> Orbit;
        public float OrbitPosition;
        public float A, B, C, D;

        public double Data = 0;
        public int DestroyProgress = 0;
        public int DestroyingSpeed = 5;
        public bool Destroyed = false;

        public event EventHandler<string> OnStateChanged;
        public event EventHandler<List<string>> OnDataSent;
        public event EventHandler OnDestroy;

        private Mode mode = Mode.Temperature;
        public State State = State.Stopped;
        public EmergencyType Emergency = EmergencyType.Null;

        public List<string> History = new List<string>();
        private Thread localThread;

        public Satellite()
        {
            Orbit = (float a, float b, float c, float d, float x) => { return (float)(-a * Math.Sin(2 * Math.PI * x / b - c / 100f) + d / 2); };
        }
        public Satellite(SatelliteInfo info)
        {
            ID = info.Id;
            Name = info.Name;
            SatelliteType = info.SatelliteType;
            OrbitPosition = info.OrbitPosition;
            A = info.A;
            B = info.B;
            C = info.C;
            D = info.D;
            Orbit = (float a, float b, float c, float d, float x) => { return (float)(-a * Math.Sin(2 * Math.PI * x / b - c / 100f) + d / 2); };
        }

        public void SetOperationMode(Mode newMode)
        {
            mode = newMode;
            Reload();
        }

        public void SatelliteWork()
        {
            while (!Destroyed)
            {
                OrbitPosition = (OrbitPosition += Settings.Velocity) % B;
                Thread.Sleep(Settings.SatelliteDelay);
                if (State == State.Running)
                {
                    switch (mode)
                    {
                        case Mode.Temperature:
                            Data = SatellitesManager.Instance.Rnd.Next(-2000, 2000) / 10f;
                            break;
                        case Mode.Radiation:
                            Data = SatellitesManager.Instance.Rnd.Next(0, 500) / 10f;
                            break;
                    }
                    History.Add($"({DateTime.Now}) | Mode:{mode} | Data:{Data}");

                    if (new Random().Next(1, 101) <= Settings.Emergency)
                    {
                        Emergency = (EmergencyType)(SatellitesManager.Instance.Rnd.Next(1, 4));
                        State = State.Error;
                        History.Add($"({DateTime.Now}) | Emergency | EmergencyType:{Emergency}");
                    }
                }
                else if (State == State.Stopped)
                {
                    if (new Random().Next(1, 101) <= Settings.Emergency)
                    {
                        Emergency = (EmergencyType)(SatellitesManager.Instance.Rnd.Next(1, 4));
                        State = State.Error;
                        History.Add($"({DateTime.Now}) | Emergency | EmergencyType:{Emergency}");
                    }
                }
                else if (State == State.Error)
                {
                    DestroyProgress += DestroyingSpeed;
                    if (DestroyProgress >= 100)
                    {
                        Destroy();
                    }
                }
                else if (State == State.Empty)
                {
                    break;
                }
            }
        }

        public void Start()
        {
            State = State.Empty;
            localThread?.Join();
            State = State.Running;
            localThread = new Thread(SatelliteWork);
            localThread.Start();
            OnStateChanged?.Invoke(this, "Running");
            History.Add($"({DateTime.Now}) | StateChange | State:{State}");
        }
        public void Stop()
        {
            State = State.Empty;
            localThread.Join();
            State = State.Stopped;
            localThread = new Thread(SatelliteWork);
            localThread.Start();
            OnStateChanged?.Invoke(this, "Stopped");
            History.Add($"({DateTime.Now}) | StateChange | State:{State}");
        }
        public void Reload()
        {
            State = State.Empty;
            localThread.Join();
            localThread = new Thread(SatelliteWork);
            localThread.Start();
            State = State.Running;
            History.Clear();
            OnStateChanged?.Invoke(this, "Reloaded");
            History.Add($"({DateTime.Now}) | StateChange | State:{State}");
        }
        public void Repair()
        {
            State = State.Empty;
            History.Add($"({DateTime.Now}) | StateChange | State:{State}");
            localThread.Join();
            localThread = new Thread(SatelliteWork);
            localThread.Start();
            State = State.Running;
            History.Add($"({DateTime.Now}) | StateChange | State:{State}");
            History.Add($"({DateTime.Now}) | Repaired");
            Emergency = EmergencyType.Null;
            OnStateChanged?.Invoke(this, "Repaired");
        }
        public void Destroy()
        {
            History.Add("Destroyed");
            Destroyed = true;
            State = State.Empty;
            OnDestroy?.Invoke(this, new EventArgs());
        }
        public void GetData()
        {
            OnDataSent?.Invoke(this, History);
        }
        public Tuple<Mode, State> GetInfo()
        {
            return new Tuple<Mode, State>(mode, State);
        }
        public void SetupOrbit(float a, float b, float c, float d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public Tuple<float, float> GetMapPosition()
        {
            return new Tuple<float, float>(OrbitPosition, Orbit(A, B, C, D, OrbitPosition));
        }
        public SatelliteInfo GetSatelliteInfo()
        {
            return new SatelliteInfo(ID, Name, SatelliteType, OrbitPosition, A, B, C, D);
        }
        public Point GetPosition()
        {
            return new Point((int)OrbitPosition, (int)Orbit(A, B, C, D, OrbitPosition));
        }
        public float GetTimePositionPercent()
        {
            float Ux = Settings.UserPosition.X;
            float Sx = OrbitPosition;
            float W = B;
            float Ut = DateTime.Now.Hour * 60 * 60 + DateTime.Now.Minute * 60 + DateTime.Now.Second;

            float t, t1;
            if (Ut > 43200)
            {
                t = (43200 * Ux) / Ut;
                t1 = (t + W / 2) % W;
            }
            else
            {
                t1 = (43200 * Ux) / Ut;
                t = (t1 + W / 2) % W;
            }

            float x;
            if (Math.Abs(t - Sx) <= W / 2)
            {
                x = (Math.Abs(t - Sx) * 100) / Math.Abs(t - t1);
            }
            else
            {
                x = ((Math.Abs(t - Sx) % (W / 2)) * 100) / Math.Abs(t - t1);
            }

            return x;
        }
    }

    public sealed class SatellitesManager
    {
        #region Singleton
        public static SatellitesManager Instance { get; private set; } = new SatellitesManager();
        static SatellitesManager()
        {

        }
        private SatellitesManager()
        {

        }
        #endregion

        public List<Satellite> Satellites = new List<Satellite>();
        public Random Rnd = new Random();

        public void AddSatellite(Satellite satellite)
        {
            Satellites.Add(satellite);
            satellite.Start();
        }

        public List<SatelliteInfo> GetListToSave()
        {
            List<SatelliteInfo> list = new List<SatelliteInfo>();
            foreach (Satellite satellite in Satellites)
            {
                list.Add(satellite.GetSatelliteInfo());
            }
            return list;
        }
        public void LoadSatellites(List<SatelliteInfo> list)
        {
            Satellites.Clear();
            foreach (SatelliteInfo info in list)
            {
                AddSatellite(new Satellite(info));
            }
        }
        public void CloseAllSatellites()
        {
            foreach (Satellite satellite in Satellites)
            {
                satellite.Destroy();
            }
        }
    }
}
