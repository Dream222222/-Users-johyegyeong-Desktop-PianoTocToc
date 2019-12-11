// Native Audio
// 5argon - Exceed7 Experiments
// Problems/suggestions : 5argon@exceed7.com

namespace E7.Native
{
    public partial class NativeAudio
    {
        public class LoadOptions
        {
            public static readonly LoadOptions defaultOptions = new LoadOptions();
            public enum ResamplingQuality
            {
                //SINC_BEST_QUALITY = 0,
                //SINC_MEDIUM_QUALITY = 1,

                /// <summary>
                /// Use a coefficients from sinc wave for reconstruction. Takes a bit of time to complete.
                /// Some benchmark : Resampling a WAV file of about 2MB (this is quite big) from 44.1kHz to 48kHz freezes the screen for 0.4 seconds on an Xperia Z5.
                /// (See https://ccrma.stanford.edu/~jos/resample/)
                /// </summary>
                SINC_FASTEST = 2,

                /// <summary>
                /// Just use the previous value for any missing data. It is the fastest resampling method but might sounds poor.
                /// </summary>
                ZERO_ORDER_HOLD = 3,

                /// <summary>
                /// The missing value will be linearly interpolated. Faster than sinc resampling.
                /// </summary>
                LINEAR = 4,
            };

            /// <summary>
            /// The quality which libsamplerate will use to resample your audio to match the device's native rate.
            /// 
            /// However two top quality setting has been removed from the source code since the sinc wave constant coefficients
            /// are needed and could potentially make Native Audio sized at 0.79MB (For medium quality) or 9.2MB (For best quality)
            /// 
            /// If you really need it, you can uncomment and then go modify back the source and recompile with the missing coefficients.
            /// </summary>
            public ResamplingQuality resamplingQuality = ResamplingQuality.SINC_FASTEST;
        }

    }
}