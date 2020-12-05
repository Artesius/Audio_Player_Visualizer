using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass;

namespace Audio_Player
{
    public static class BassAudio
    {
        private static int DRate = 44100;
        public static bool InitDefaultDevice;
        public static int Stream;
        public static int Volume = 100;

        private static readonly List<int> BassPluginsHandles = new List<int>();
        public static bool InitBass(int hz)
        {
            if (!InitDefaultDevice)
            {
                InitDefaultDevice = Bass.BASS_Init(-1, hz, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
                if (InitDefaultDevice)
                {
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bass_aac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\basstta.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bassalac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bassflac.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\bassopus.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\basswma.dll"));
                    BassPluginsHandles.Add(Bass.BASS_PluginLoad(Variables.AppPath + @"plugins\basswv.dll"));
                }
            }
            return InitDefaultDevice;
        }
        public static void Play(string file_name, int vol)
        {
            if (Bass.BASS_ChannelIsActive(Stream) != BASSActive.BASS_ACTIVE_PAUSED)
            {
                Stop();
                if (InitBass(DRate))
                {
                    Stream = Bass.BASS_StreamCreateFile(file_name, 0, 0, BASSFlag.BASS_DEFAULT);
                    if (Stream != 0)
                    {
                        Volume = vol;
                        Bass.BASS_ChannelSetAttribute(Stream, BASSAttribute.BASS_ATTRIB_VOL, Volume / 100);
                        Bass.BASS_ChannelPlay(Stream, false);
                    }
                }
            }
            else Bass.BASS_ChannelPlay(Stream, false);
        }
        public static void Stop()
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
        }
        public static void Pause()
        {
            if(Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_PLAYING) Bass.BASS_ChannelPause(Stream);
        }
        public static int GetTimeOfStream(int stream)
        {
            long TimeBytes = Bass.BASS_ChannelGetLength(stream);
            double Time = Bass.BASS_ChannelBytes2Seconds(stream, TimeBytes);
            return (int)Time;
        }
        public static int GetPositionOfStream(int stream)
        {
            long Pos = Bass.BASS_ChannelGetPosition(stream);
            int CurPos = (int)Bass.BASS_ChannelBytes2Seconds(stream, Pos);
            return CurPos;
        }
        public static void SetPositionOfScroll(int stream, int pos)
        {
            Bass.BASS_ChannelSetPosition(stream, (double)pos);
        }
        public static void SetVolumeToStream(int stream, int vol)
        {
            Volume = vol;
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, (float)Volume / 100);
        }
    }
}
