// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace PortAudioNet
{
    public unsafe static partial class PortAudio
    {
        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetVersion", ExactSpelling = true)]
        public static extern int GetVersion();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetVersionText", ExactSpelling = true)]
        public static extern byte* GetVersionText();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetVersionInfo", ExactSpelling = true)]
        public static extern PaVersionInfo* GetVersionInfo();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetErrorText", ExactSpelling = true)]
        public static extern byte* GetErrorText(PaError errorCode);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_Initialize", ExactSpelling = true)]
        public static extern PaError Initialize();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_Terminate", ExactSpelling = true)]
        public static extern PaError Terminate();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetHostApiCount", ExactSpelling = true)]
        public static extern int GetHostApiCount();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetDefaultHostApi", ExactSpelling = true)]
        public static extern int GetDefaultHostApi();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetHostApiInfo", ExactSpelling = true)]
        public static extern PaHostApiInfo* GetHostApiInfo(int hostApi);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_HostApiTypeIdToHostApiIndex", ExactSpelling = true)]
        public static extern int HostApiTypeIdToHostApiIndex(PaHostApiTypeId type);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_HostApiDeviceIndexToDeviceIndex", ExactSpelling = true)]
        public static extern int HostApiDeviceIndexToDeviceIndex(int hostApi, int hostApiDeviceIndex);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetLastHostErrorInfo", ExactSpelling = true)]
        public static extern PaHostErrorInfo* GetLastHostErrorInfo();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetDeviceCount", ExactSpelling = true)]
        public static extern int GetDeviceCount();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetDefaultInputDevice", ExactSpelling = true)]
        public static extern int GetDefaultInputDevice();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetDefaultOutputDevice", ExactSpelling = true)]
        public static extern int GetDefaultOutputDevice();

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetDeviceInfo", ExactSpelling = true)]
        public static extern PaDeviceInfo* GetDeviceInfo(int device);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_IsFormatSupported", ExactSpelling = true)]
        public static extern PaError IsFormatSupported(PaStreamParameters* inputParameters, PaStreamParameters* outputParameters, double sampleRate);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_OpenStream", ExactSpelling = true)]
        public static extern PaError OpenStream(void** stream, PaStreamParameters* inputParameters, PaStreamParameters* outputParameters, double sampleRate, uint framesPerBuffer, PaStreamFlags streamFlags, delegate* unmanaged[Cdecl]<void*, void*, uint, PaStreamCallbackTimeInfo*, PaStreamCallbackFlags, void*, int> streamCallback, void* userData);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_OpenDefaultStream", ExactSpelling = true)]
        public static extern PaError OpenDefaultStream(void** stream, int numInputChannels, int numOutputChannels, PaSampleFormat sampleFormat, double sampleRate, uint framesPerBuffer, delegate* unmanaged[Cdecl]<void*, void*, uint, PaStreamCallbackTimeInfo*, PaStreamCallbackFlags, void*, int> streamCallback, void* userData);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_CloseStream", ExactSpelling = true)]
        public static extern PaError CloseStream(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_SetStreamFinishedCallback", ExactSpelling = true)]
        public static extern PaError SetStreamFinishedCallback(void* stream, delegate* unmanaged[Cdecl]<void*, void> streamFinishedCallback);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_StartStream", ExactSpelling = true)]
        public static extern PaError StartStream(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_StopStream", ExactSpelling = true)]
        public static extern PaError StopStream(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_AbortStream", ExactSpelling = true)]
        public static extern PaError AbortStream(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_IsStreamStopped", ExactSpelling = true)]
        public static extern PaError IsStreamStopped(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_IsStreamActive", ExactSpelling = true)]
        public static extern PaError IsStreamActive(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetStreamInfo", ExactSpelling = true)]
        public static extern PaStreamInfo* GetStreamInfo(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetStreamTime", ExactSpelling = true)]
        public static extern double GetStreamTime(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetStreamCpuLoad", ExactSpelling = true)]
        public static extern double GetStreamCpuLoad(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_ReadStream", ExactSpelling = true)]
        public static extern PaError ReadStream(void* stream, void* buffer, uint frames);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_WriteStream", ExactSpelling = true)]
        public static extern PaError WriteStream(void* stream, void* buffer, uint frames);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetStreamReadAvailable", ExactSpelling = true)]
        public static extern int GetStreamReadAvailable(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetStreamWriteAvailable", ExactSpelling = true)]
        public static extern int GetStreamWriteAvailable(void* stream);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_GetSampleSize", ExactSpelling = true)]
        public static extern PaError GetSampleSize(PaSampleFormat format);

        [DllImport("portaudio.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Pa_Sleep", ExactSpelling = true)]
        public static extern void Sleep(int msec);

        public const int NoDevice = -1;

        public const int UseHostApiSpecificDeviceSpecification = -2;

        public const PaError FormatIsSupported = PaError.NoError;

        public const uint FramesPerBufferUnspecified = 0;
    }
}
