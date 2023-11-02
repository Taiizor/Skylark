namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppExtensionType
    {
        /// <summary>
        /// 
        /// </summary>
        EXE,
        /// <summary>
        /// 
        /// </summary>
        MSI
    }

    /// <summary>
    /// 
    /// </summary>
    public enum WebExtensionType
    {
        /// <summary>
        /// 
        /// </summary>
        HTM,
        /// <summary>
        /// 
        /// </summary>
        XML,
        /// <summary>
        /// 
        /// </summary>
        HTML,
        /// <summary>
        /// 
        /// </summary>
        SHTML,
        /// <summary>
        /// 
        /// </summary>
        XHTML
    }

    /// <summary>
    /// 
    /// </summary>
    public enum VideoExtensionType
    {
        /// <summary>
        /// An MP4 file is a multimedia file that stores a movie or video clip and may also contain
        /// subtitles, images, and metadata. It is one of the most common formats used for distributing
        /// video online, whether it be streaming or sharing videos.
        /// </summary>
        MP4,
        /// <summary>
        /// An AVI file is a video file saved in the Audio Video Interleave (AVI) multimedia container
        /// format created by Microsoft. It stores video and audio data encoded in various codecs,
        /// including DivX and XviD.
        /// </summary>
        AVI,
        /// <summary>
        /// A MOV file is one of the most common video file types, often storing a movie, TV show,
        /// short video clip, or home movie. It is saved in the QuickTime File Format (QTFF), a multimedia
        /// container format developed by Apple. Video editors commonly save video as MOV files due to
        /// their support for high-quality video.
        /// </summary>
        MOV,
        /// <summary>
        /// An MKV file is a video file saved in the Matroska multimedia container format that often
        /// stores short video clips, TV shows, and movies. It supports several types of audio and video
        /// codecs and may include .SRT, .SSA, .USF (Universal Subtitle Format), or VobSub subtitles.
        /// Many video players can open MKV files, including the Microsoft Movies and TV app bundled with
        /// Windows and the free VideoLAN VLC media player.
        /// </summary>
        MKV,
        /// <summary>
        /// An OGV file is a video file saved in the Xiph.Org open-source Ogg container format.
        /// It contains video streams encoded with one or more codecs, such as Theora, Dirac, or Daala,
        /// and may or may not store audio streams. Users often utilize OGV files to save video content
        /// for publishing on webpages.
        /// </summary>
        OGV,
        /// <summary>
        /// An HEVC file contains a video stored in the High Efficiency Video Coding (HEVC) format.
        /// This format, also known as H.265, improves over the H.264 standard by allowing videos to
        /// be stored with a lower file size but with the same video quality. HEVC helps users store
        /// more videos on their devices and also substantially reduces the file size of high-resolution
        /// videos such as 4K and 8K videos.
        /// </summary>
        HEVC,
        /// <summary>
        /// An FLV file is a video saved in the Adobe Flash Video (FLV) container format.
        /// It stores a short header, synchronized audio and video data streams
        /// (encoded the same way as streams in the standard Flash .SWF format), and metadata
        /// packets.
        /// </summary>
        FLV,
        /// <summary>
        /// A WEBM file is a video saved in the WebM format, an open, royalty-free format designed
        /// for sharing video on the web. WebM uses a container structure similar to the Matroska
        /// (.MKV) video format, which stores both audio and video data. Video is compressed using
        /// a VP8 or VP9 codec, and audio is compressed with either the Vorbis or Opus audio codec.
        /// </summary>
        WEBM,
        /// <summary>
        /// A WMV file is a video saved in the Microsoft Advanced Systems Format (ASF) and compressed
        /// with Windows Media Video (WMV) compression. It may store an animation, video clip, TV episode,
        /// or movie and supports high-definition (HD) video. WMV files also support encryption for use with
        /// Digital Rights Management (DRM) systems.
        /// </summary>
        WMV,
        /// <summary>
        /// An MPEG file is a video file that uses a digital video format standardized by the Moving
        /// Picture Experts Group (MPEG). It contains video and audio that are compressed using MPEG-1
        /// or MPEG-2 compression. MPEG files are typically used to share videos over the Internet.
        /// </summary>
        MPEG,
        /// <summary>
        /// Video file compressed using the MPEG-1 codec; may include both audio and video, though the
        /// audio track may use a separate type of compression; can be opened and played back by most
        /// media players
        /// </summary>
        MPEG1,
        /// <summary>
        /// An MPEG2 file is a video file encoded using the MPEG-2 codec, which is typically used to
        /// compress over-the-air, satellite, and cable TV transmissions, as well as DVD video. It is
        /// compressed using lossy compression, which significantly reduces the size of the video and
        /// audio data it contains. MPEG-2 compression is less efficient than H.264 (.H264) compression.
        /// </summary>
        MPEG2,
        /// <summary>
        /// An MPEG4 file is a video file saved in the MPEG-4 container format. It includes both audio
        /// and video data and supports multiple A/V codecs. MPEG4 files are commonly used for distributing
        /// video content over the web and for streaming videos on the Internet.
        /// </summary>
        MPEG4
    }
}