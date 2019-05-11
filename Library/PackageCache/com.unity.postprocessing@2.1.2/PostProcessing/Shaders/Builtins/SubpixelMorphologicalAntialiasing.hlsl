e in Hertz.</para>
      </returns>
    </member>
    <member name="T:UnityEngine.Video.VideoPlayer">
      <summary>
        <para>Plays video content onto a target.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.aspectRatio">
      <summary>
        <para>Defines how the video content will be stretched to fill the target area.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.audioOutputMode">
      <summary>
        <para>Destination for the audio embedded in the video.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.audioTrackCount">
      <summary>
        <para>Number of audio tracks found in the data source currently configured. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canSetDirectAudioVolume">
      <summary>
        <para>Whether direct-output volume controls are supported for the current platform and video format. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canSetPlaybackSpeed">
      <summary>
        <para>Whether the playback speed can be changed. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canSetSkipOnDrop">
      <summary>
        <para>Whether frame-skipping to maintain synchronization can be controlled. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canSetTime">
      <summary>
        <para>Whether current time can be changed using the time or timeFrames property. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canSetTimeSource">
      <summary>
        <para>Whether the time source followed by the VideoPlayer can be changed. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.canStep">
      <summary>
        <para>Returns true if the VideoPlayer can step forward through the video content. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.clip">
      <summary>
        <para>The clip being played by the VideoPlayer.</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.clockResyncOccurred(UnityEngine.Video.VideoPlayer/TimeEventHandler)">
      <summary>
        <para>Invoked when the VideoPlayer clock is synced back to its Video.VideoTimeReference.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.clockTime">
      <summary>
        <para>The clock time that the VideoPlayer follows to schedule its samples. The clock time is expressed in seconds. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.controlledAudioTrackCount">
      <summary>
        <para>Number of audio tracks that this VideoPlayer will take control of.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.controlledAudioTrackMaxCount">
      <summary>
        <para>Maximum number of audio tracks that can be controlled. (Read Only)</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.errorReceived(UnityEngine.Video.VideoPlayer/ErrorEventHandler)">
      <summary>
        <para>Errors such as HTTP connection problems are reported through this callback.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.externalReferenceTime">
      <summary>
        <para>Reference time of the external clock the Video.VideoPlayer uses to correct its drift.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.frame">
      <summary>
        <para>The frame index of the currently available frame in VideoPlayer.texture.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.frameCount">
      <summary>
        <para>Number of frames in the current video content. (Read Only)</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.frameDropped(UnityEngine.Video.VideoPlayer/EventHandler)">
      <summary>
        <para>[NOT YET IMPLEMENTED] Invoked when the video decoder does not produce a frame as per the time source during playback.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.frameRate">
      <summary>
        <para>The frame rate of the clip or URL in frames/second. (Read Only)</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.frameReady(UnityEngine.Video.VideoPlayer/FrameReadyEventHandler)">
      <summary>
        <para>Invoked when a new frame is ready.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.height">
      <summary>
        <para>The height of the images in the VideoClip, or URL, in pixels. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.isLooping">
      <summary>
        <para>Determines whether the VideoPlayer restarts from the beginning when it reaches the end of the clip.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.isPaused">
      <summary>
        <para>Whether playback is paused. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.isPlaying">
      <summary>
        <para>Whether content is being played. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.isPrepared">
      <summary>
        <para>Whether the VideoPlayer has successfully prepared the content to be played. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.length">
      <summary>
        <para>The length of the VideoClip, or the URL, in seconds. (Read Only)</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.loopPointReached(UnityEngine.Video.VideoPlayer/EventHandler)">
      <summary>
        <para>Invoked when the VideoPlayer reaches the end of the content to play.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.pixelAspectRatioDenominator">
      <summary>
        <para>Denominator of the pixel aspect ratio (num:den) for the VideoClip or the URL. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.pixelAspectRatioNumerator">
      <summary>
        <para>Numerator of the pixel aspect ratio (num:den) for the VideoClip or the URL. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.playbackSpeed">
      <summary>
        <para>Factor by which the basic playback rate will be multiplied.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.playOnAwake">
      <summary>
        <para>Whether the content will start playing back as soon as the component awakes.</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.prepareCompleted(UnityEngine.Video.VideoPlayer/EventHandler)">
      <summary>
        <para>Invoked when the VideoPlayer preparation is complete.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.renderMode">
      <summary>
        <para>Where the video content will be drawn.</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.seekCompleted(UnityEngine.Video.VideoPlayer/EventHandler)">
      <summary>
        <para>Invoke after a seek operation completes.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.sendFrameReadyEvents">
      <summary>
        <para>Enables the frameReady events.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.skipOnDrop">
      <summary>
        <para>Whether the VideoPlayer is allowed to skip frames to catch up with current time.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.source">
      <summary>
        <para>The source that the VideoPlayer uses for playback.</para>
      </summary>
    </member>
    <member name="?:UnityEngine.Video.VideoPlayer.started(UnityEngine.Video.VideoPlayer/EventHandler)">
      <summary>
        <para>Invoked immediately after Play is called.</para>
      </summary>
      <param name="value"></param>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetCamera">
      <summary>
        <para>Camera component to draw to when Video.VideoPlayer.renderMode is set to either Video.VideoRenderMode.CameraFarPlane or Video.VideoRenderMode.CameraNearPlane.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetCamera3DLayout">
      <summary>
        <para>Type of 3D content contained in the source video media.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetCameraAlpha">
      <summary>
        <para>Overall transparency level of the target camera plane video.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetMaterialProperty">
      <summary>
        <para>Material texture property which is targeted when Video.VideoPlayer.renderMode is set to Video.VideoTarget.MaterialOverride.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetMaterialRenderer">
      <summary>
        <para>Renderer which is targeted when Video.VideoPlayer.renderMode is set to Video.VideoTarget.MaterialOverride</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.targetTexture">
      <summary>
        <para>RenderTexture to draw to when Video.VideoPlayer.renderMode is set to Video.VideoTarget.RenderTexture.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.texture">
      <summary>
        <para>Internal texture in which video content is placed. (Read Only)</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.time">
      <summary>
        <para>The presentation time of the currently available frame in VideoPlayer.texture.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.timeReference">
      <summary>
        <para>The clock that the Video.VideoPlayer observes to detect and correct drift.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.timeSource">
      <summary>
        <para>[NOT YET IMPLEMENTED] The source used used by the VideoPlayer to derive its current time.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.url">
      <summary>
        <para>The file or HTTP URL that the VideoPlayer reads content from.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.waitForFirstFrame">
      <summary>
        <para>Determines whether the VideoPlayer will wait for the first frame to be loaded into the texture before starting playback when Video.VideoPlayer.playOnAwake is on.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoPlayer.width">
      <summary>
        <para>The width of the images in the VideoClip, or URL, in pixels. (Read Only)</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.EnableAudioTrack(System.UInt16,System.Boolean)">
      <summary>
        <para>Enable/disable audio track decoding. Only effective when the VideoPlayer is not currently playing.</para>
      </summary>
      <param name="trackIndex">Index of the audio track to enable/disable.</param>
      <param name="enabled">True for enabling the track. False for disabling the track.</param>
    </member>
    <member name="T:UnityEngine.Video.VideoPlayer.ErrorEventHandler">
      <summary>
        <para>Delegate type for VideoPlayer events that contain an error message.</para>
      </summary>
      <param name="source">The VideoPlayer that is emitting the event.</param>
      <param name="message">Message describing the error just encountered.</param>
    </member>
    <member name="T:UnityEngine.Video.VideoPlayer.EventHandler">
      <summary>
        <para>Delegate type for all parameterless events emitted by VideoPlayers.</para>
      </summary>
      <param name="source">The VideoPlayer that is emitting the event.</param>
    </member>
    <member name="T:UnityEngine.Video.VideoPlayer.FrameReadyEventHandler">
      <summary>
        <para>Delegate type for VideoPlayer events that carry a frame number.</para>
      </summary>
      <param name="source">The VideoPlayer that is emitting the event.</param>
      <param name="frameNum">The current frame of the VideoPlayer.</param>
      <param name="frameIdx"></param>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetAudioChannelCount(System.UInt16)">
      <summary>
        <para>The number of audio channels in the specified audio track.</para>
      </summary>
      <param name="trackIndex">Index for the audio track being queried.</param>
      <returns>
        <para>Number of audio channels.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetAudioLanguageCode(System.UInt16)">
      <summary>
        <para>Returns the language code, if any, for the specified track.</para>
      </summary>
      <param name="trackIndex">Index of the audio track to query.</param>
      <returns>
        <para>Language code.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetAudioSampleRate(System.UInt16)">
      <summary>
        <para>Gets the audio track sampling rate in Hertz.</para>
      </summary>
      <param name="trackIndex">Index of the audio track to query.</param>
      <returns>
        <para>The sampling rate in Hertz.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetDirectAudioMute(System.UInt16)">
      <summary>
        <para>Gets the direct-output audio mute status for the specified track.</para>
      </summary>
      <param name="trackIndex"></param>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetDirectAudioVolume(System.UInt16)">
      <summary>
        <para>Return the direct-output volume for specified track.</para>
      </summary>
      <param name="trackIndex">Track index for which the volume is queried.</param>
      <returns>
        <para>Volume, between 0 and 1.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.GetTargetAudioSource(System.UInt16)">
      <summary>
        <para>Gets the AudioSource that will receive audio samples for the specified track if Video.VideoPlayer.audioOutputMode is set to Video.VideoAudioOutputMode.AudioSource.</para>
      </summary>
      <param name="trackIndex">Index of the audio track for which the AudioSource is wanted.</param>
      <returns>
        <para>The source associated with the audio track.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.IsAudioTrackEnabled(System.UInt16)">
      <summary>
        <para>Whether decoding for the specified audio track is enabled. See Video.VideoPlayer.EnableAudioTrack for distinction with mute.</para>
      </summary>
      <param name="trackIndex">Index of the audio track being queried.</param>
      <returns>
        <para>Returns true if decoding for the specified audio track is enabled.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.Pause">
      <summary>
        <para>Pauses the playback and leaves the current time intact.</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.Play">
      <summary>
        <para>Starts playback.</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.Prepare">
      <summary>
        <para>Initiates playback engine preparation.</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.SetDirectAudioMute(System.UInt16,System.Boolean)">
      <summary>
        <para>Set the direct-output audio mute status for the specified track.</para>
      </summary>
      <param name="trackIndex">Track index for which the mute is set.</param>
      <param name="mute">Mute on/off.</param>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.SetDirectAudioVolume(System.UInt16,System.Single)">
      <summary>
        <para>Set the direct-output audio volume for the specified track.</para>
      </summary>
      <param name="trackIndex">Track index for which the volume is set.</param>
      <param name="volume">New volume, between 0 and 1.</param>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.SetTargetAudioSource(System.UInt16,UnityEngine.AudioSource)">
      <summary>
        <para>Sets the AudioSource that will receive audio samples for the specified track if this audio target is selected with Video.VideoPlayer.audioOutputMode.</para>
      </summary>
      <param name="trackIndex">Index of the audio track to associate with the specified AudioSource.</param>
      <param name="source">AudioSource to associate with the audio track.</param>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.StepForward">
      <summary>
        <para>Advances the current time by one frame immediately.</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoPlayer.Stop">
      <summary>
        <para>Stops the playback and sets the current time to 0.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoPlayer.TimeEventHandler">
      <summary>
        <para>Delegate type for VideoPlayer events that carry a time position.</para>
      </summary>
      <param name="source">The VideoPlayer that is emitting the event.</param>
      <param name="seconds">Time position.</param>
    </member>
    <member name="T:UnityEngine.Video.VideoRenderMode">
      <summary>
        <para>Type of destination for the images read by a VideoPlayer.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoRenderMode.APIOnly">
      <summary>
        <para>Don't draw the video content anywhere, but still make it available via the VideoPlayer's texture property in the API.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoRenderMode.CameraFarPlane">
      <summary>
        <para>Draw video content behind a camera's Scene.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoRenderMode.CameraNearPlane">
      <summary>
        <para>Draw video content in front of a camera's Scene.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoRenderMode.MaterialOverride">
      <summary>
        <para>Draw the video content into a user-specified property of the current GameObject's material.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoRenderMode.RenderTexture">
      <summary>
        <para>Draw video content into a RenderTexture.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoSource">
      <summary>
        <para>Source of the video content for a VideoPlayer.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoSource.Url">
      <summary>
        <para>Use the current URL as the video content source.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoSource.VideoClip">
      <summary>
        <para>Use the current clip as the video content source.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoTimeReference">
      <summary>
        <para>The clock that the Video.VideoPlayer observes to detect and correct drift.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoTimeReference.ExternalTime">
      <summary>
        <para>External reference clock the Video.VideoPlayer observes to detect and correct drift.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoTimeReference.Freerun">
      <summary>
        <para>Disables the drift detection.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoTimeReference.InternalTime">
      <summary>
        <para>Internal reference clock the Video.VideoPlayer observes to detect and correct drift.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoTimeSource">
      <summary>
        <para>Time source followed by the Video.VideoPlayer when reading content.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoTimeSource.AudioDSPTimeSource">
      <summary>
        <para>The audio hardware clock.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoTimeSource.GameTimeSource">
      <summary>
        <para>The unscaled game time as defined by Time.realtimeSinceStartup.</para>
      </summary>
    </member>
  </members>
</doc>
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           MZ�       ��  �       @                                   �   � �	�!�L�!This program cannot be run in DOS mode.
$       PE  L             � !  �         ��            @                                 @�                           l�  O    �                                                                                             H           .text   ĥ       �                    `.rsrc       �      �              @  @.reloc            �              @  B                ��      H     �A  ��                                                         0 ;      :   
8+   �io  
o  
<   o  
o  

8    * 0 3      r  p|  r  p(  
|  r  p(  
(  

8    * 0 ,      |  �  o  
|  �  o  
a
8    *0 #      u  9   �  (  +
8    * 0 -      {  {  @   {  {  �+
8    *   0 /       {  {  @    {  {  �+
8    * 0 2       {  {  @    {  {  ��+
8    *  0       ~  
8    *  0       �  �  *(
  
* 0       {  (#  
8    *0       {  
8    *& }  *   0      {  
8    *"}  * 0      {  
8    *"}  *(  * 0 ;      {  ("  
(  �  �  9    �  }   8    *(  * 0 7   	   (  (  
u  �  
�  }  �  (  8    *n }  o.  ~  o  
* 0 `   
    ~  o  
8   (  

 t  ~  
}   (  
:�����   �  o  
�~  o  
~  o  
*    0=     0 h      ~  o  
Y
8M    ~  o  
t  {  (  
9'    ~  o  
t  ~  
}  ~  o  
  Y
<����*0 a       ~  o  
8'   (  
t  
 {  (  
9   �'    (  
:�����   �  o  
�8    *       =J     6 ~  o  
*Vs  
�  s  
�  *0 �       ~  o  
8   (  

 @   ݉    (  
:�����   �  o  
�~  o   
~	  :!    r  pddr9  pr;  p(!  
&�	   �  o  }  r  p	�  ~"  
(#  
&8    *    .;     R o  ~
  o$  
*   0 Q       ~
  o%  
8   (&  

 ~  
o   ('  
:�����   �	  o  
�~
  o(  
*       +8     n�	  s*  
�
  s+  
�  * ()  *0 �      o  
 ~
  o%  
8!   (&  

 u
  9   �
  o,  
 ('  
:�����   �	  o  
� ~  o  
8!   (  
 u
  9   �
  o,  
 (  
:�����   �  o  
�*      7J      d 7�     0 �      o  
 ~  o  
8!   (  

 u
  9   �
  o,  
 (  
:�����   �  o  
� ~  o  
8!   (  
 u
  9   �
  o,  
 (  
:�����   �  o  
�*      7J      d 7�     0       {  
{  (  ((  *(-  *  0       {  �  
8    *(4  *0       {  �  
8    *0 (     ~  
  (-  
t  (  +
@����*0 (     ~  
  (/  
t  (  +
@����*0 (     ~  
  (-  
t  (  +
@����*0 (     ~  
  (/  
t  (  +
@����*0 (     ~  
  (-  
t  (  +
@����*0 (     ~  
  (/  
t  (  +
@����*0 (     ~  
  (-  
t  (  +
@����*0 (     ~  
  (/  
t  (  +
@����*0 �      
�  (V  (X  (Z  E      &         8,   ~  
87   ~  
8,   ~  
8!   ~  
8   rI  p�  (0  
s1  
z9	    o2  
 *0 
      (S  *  0 
      (T  *� :    r�  ps4  
zo5  
(H  *f�  �  �  �  *   0       {4  
8    *& }4  *   0       {+  
8    *& }+  *   0       {3  �
8    *V 9   8   }3  *^ }-  %{,  `},  *^ }.  %{,  `},  *^ }/  %{,  `},  *^ }0  %{,  `},  *b }1  %{,  `},  *b }2  %{,   `},  *  0       {-  (  +
8    * 0       {.  (  +
8    * 0       {/  (  +
8    * 0       {0  (  +
8    * 0       {1  (  +
8    *0       {2   (  +
8    *0 ?      {3  @   {,  _>    �
  
8    (  +�
  
8    * 0       {5  
8    *& }5  *   0       {6  
8    *& }6  *   0       {7  
8    *& }7  *   0       {8  
8    *& }8  *   0 '      u  :   
8   �  (q  
8    * 0 Q      (h  (h  @5   (j  (j  @#   (l  (l  @   (n  (n  �+
8    *   0 d      (h  
 �#  o  
(j  �$  o  
ba(l  �$  o  
ca(n  �#  o  
ba8    *0        (q  
8    *   0       (s  �
8    *& }9  *   0       {9  (P  
8    *0       {9  (L  
8    * 0       {9  (M  
8    *  0       {9  (N  
8    *6 {9  (O  * 0 '      u  :   
8   �  (|  
8    * 0       {9  {9  �
8    *0       |9  �  o  

8    *  0        (|  
8    *   0       (~  �
8    * 0       (Q  
su  8    *  0       {:  
8    *(:  
* 0       (�  
8    *j :   r�  ps4  
z(�  * 0 *     {;  
|;  (-  
t  (  +
@����*  0 *     {;  
|;  (/  
t  (  +
@����*  0 +      {;  9    {;   �   }:  o;  
 *(<  
* 0       {<  
8    *(=  
* 0 *     {=  
|=  (-  
t  (  +
@����*  0 *     {=  
|=  (/  
t  (  +
@����*j :   r�  ps4  
z(�  *j :   r�  ps4  
z(�  *0 +      {=  9    {=   �   }<  o>  
 *(?  
*(@  
*(A  
*(B  
*(C  
*(D  
*(E  
* 0        ۢ�ZX
8    *  0      {E  
8    *  0       {F  
8    *  0    !  {G  
8    *  0    "  {H  
8    *  0    #  {I  
8    *  0 '      u)  :   
8   �)  (�  
8    * 0 �   $   (�  
 (�  (  9u   (�  (�  oF  
9^   (�  (�  oF  
9G   (�  (�  �'  �'  oF  
9"   (�  (�  �*  �*  oF  
+8    	*   0        (�  
8    *   0        (�  �
8    *0 o   %   (�  
 �  o  
(�  o  
(�  (�  o  
(�  (�  �'  o  
(�  (�  �*  o  
(�  8    	* 0      {U  
8    *"}U  * 0    &  {V  
8    *"}V  * 0      {W  
8    *"}W  * 0 '      u,  :   
8   �,  (�  
8    * 0 `   '   (�  
 (�  (  9<   (�  (�  �+  �+  oF  
9   (�  (�  (G  
+8    	*0        (�  
8    *   0        (�  �
8    *0 A   (   (�  
 �  o  
(�  �+  o  
(�  (�  (�  8    *(H  
*   0 !      :   r�  ps4  
z(�  
8    *>(�  *> 9   oI  
*(J  
*   0      {]  
8    *"}]  * 0      {^  
8    *"}^  * 0    )  {_  
8    *"}_  * 0      {`  
8    *"}`  * 0    *  {a  
8    *"}a  * 0    +  {b  
8    *"}b  * 0    ,   (�  
 {K  
8    * 0    ,   (�  
 {L  
8    * 0    -   (�  
 (M  
8    * 0    .   (�  (�  sN  

8    *  0 �   /   (�  (O  
(�  "   ?Z(P  

(�  (Q  
(�  "   ?Z(P  
(�  (R  
(R  
�  (�  (R  
(S  
�  (�  (S  
(S  
�  (�  (S  
(R  
�  * 0 ,      :   r ps4  
z{\  (�  (�  
8    *&(�  **(�  *   0    0  {c  
8    *"}c  * 0    1  {d  
8    *"}d  * 0    0  {e  
8    *"}e  * 0    1  {f  
8    *"}f  * 0    0  {g  
8    *"}g  * 0    1  {h  
8    *"}h  *(T  
* 0 *   2  {i  
|i  (-  
t!  (  +
@����*  0 *   2  {i  
|i  (/  
t!  (  +
@����*  0 *   3  {j  
|j  (-  
t"  (  +
@����*  0 *   3  {j  
|j  (/  
t"  (  +
@����*  0 *   4  {k  
|k  (-  
t#  (	  +
@����*  0 *   4  {k  
|k  (/  
t#  (	  +
@����**( *j :   r/ ps4  
z( *0 "      :   r ps4  
z(	 
8    *  0 3   5   {i  9&    {i   �1   (�   (�  oU  
 * 0 3   6   {j  9&    {j   �2   (�   (�  oV  
 * 0 3   7   {k  9&    {k   �3   (�   (�  oW  
 **( *&( *(X  
*0      {u  
8    *"}u  * 0    )  {v  
8    *"}v  * 0    8  {w  
8    *"}w  * 0    9  {x  
8    *"}x  *(Y  
* 0 L   :   :   rC ps4  
z{Z  
([  
k[(\  

{]  
(^  
k[(\  
( 8    *0 N   ;   :   rC ps4  
z:
   ~  
8   {  
:
   ~  
8   {  ( *> ( *6 ( *(_  
*0      {y  
8    *"}y  * 0    <  {z  
8    *"}z  * 0    )  {{  
8    *"}{  * 0    =  {|  
8    *"}|  * 0    <  {}  
8    *"}}  * 0    )  {~  
8    *"}~  *(`  
* 0 *   >  {  
|  (-  
t(  (
  +
@����*  0 *   >  {  
|  (/  
t(  (
  +
@����*2(9 * 0       {a  
{b  
(1 
8    *&(: **(; *j :   rY ps4  
z(7 *  0 9   ?   {  9,   {   �;   ((  (*  (, oc  
*(d  
*   0    @   {�  
8    * 0    <  {�  
8    *"}�  *(e  
* 0 *   A  {�  
|�  (-  
t+  (  +
@����*  0 *   A  {�  
|�  (/  
t+  (  +
@����*  0 3   B   {�  9&    {�   �?   }�   (? of  
 *(g  
* BSJB         v2.0.50727     l   �6  #~  7  &  #Strings    (]  �  #US �^     #GUID   �^  �$  #Blob         
W_�	   �3 �    7   A   �   F    
   l   5   �     B            Q   �      ,                             �I f �  � eI  I � I I � Y" � �. E. �I �� I ;"    *I �
I MA ,A �� = I  I �� fI
 � %
 ,% PI �� � �� �I /I � I 
I
 �%
 �%
 � %
 � %
 <% �% � I
 �%
 � %
 %
 %
 �%
 �#% �� �$% s.� 8   >� !�%    �       � �7   	 W7   �   j�   
 �   '�   
 	  ��   �  ��   	  F �     P �   � ��   � c� 	  ! �    % �  v�  % �   P�   * 	  ��  -   ' �<  2 �  ��  4 �  1 �D  8 � (  :   �  �  U   O
(�  U    �(� # U 	 	( + U 	 m( 5 h 	 �	( 9 u   {( : � 	 �7 : �   f7> ; �   �7F < � 	 L7 < �   ;7J = �   87R > �   �7V > �   �7Z > �   �7^ > �   �7b > �   �7f > �   �7j > �   �7� > � � �7 D � 	 7 E �   �7� J �   57� P � 	 �7 U �   +7v X �   7~ X �   _7� X � 	 �7 \ � 	 7 c � 	 g7 e � 	 �7 g �   �7� i �   7� l   W7� l 	 
7 u   �7� y   �7� y  	 � 7 y !	 }7 | '  �7�  -  p7� � <  �7� � =	 '7 � =  7� � @  S7� � F �B  m F  � F  
�  +�  p �� � �� �� �� ��  
�  �� �� �/ {"/  / k/�[V��^V�H^V��^V�V"^�[V��qV��qV�zqV��qV�v	qV�	qV��qV��	qV��q�[V�1�V��
�V��
�V��
�V��
�V��
�V��
� 6q W� � �� 5%� @%� A� P� j[ � F  � g� $� �% F  x� :� L� �[V���
V���
V�7�
V���
V���
Q��[! �B ! }! �! 	�
! ��[V�1V��V�^V�V�;�[V�%�V�{�V���V�`� �B  �� 8	[�[V���V�x�V��� + �B  B  �� �� g� 	� � Y � Y � Y  K ?T �]�[V�1�V��V�i�V��%�V���V���V�!�V�� �B  �� ? �� �B  B �� V	� &B �� m�[V�xBV�BV��
B 7F MB KeP     � C!-  �     � Y  �     � 
  !    � �e  @!    ��j  |!    ��%p  �!    ��%p  �!    �	} 	 "    �'� 	       ��� 	       �
� 	 /"    �! 
 8"    ��Y 
 X"    �	�� 
 s"    �	�� 
 /"    �!  �"    ��Y  �"    ���  �"    �o �"    �� �"    �!  �"    � �& #    �!   #    � �& c#    � �	� �#    � ��  �#    � 1� p$    � N� �$    � � �$    �'�  %    � .+ �%    � E8 �%    � B�       � �Q      � �e l&    �'�  �&    �'�  �&    � �� d'    � !�      � ��      � ��        �5!        ��        ��$  /"    �!       � �
�      �5!       ��  8(    ��$  ^(    �!  h(    ��& /"    �!        �5!        ��        ��$  �(    �!  �(    ��& �(    ��l �(    ��l )    �c"l L)    �t"l �)    ��l �)    ��l  �)    �Tl! *    �dl" P*    � A �# �*    � #�' +    � ��(      � �� )      � �) +    � �*      � �+      � S:,      ��`,      ���,      � U�-      � �1      � g�4      � "�6      � ��7      � 0
�8 ;+    �'� 9      � ��9      � ��; X+    �� �= s+    �	�= �+    �=�> �+    �J�> �+    �t�? �+    ���? �+    �C�@ �+    ���A ,    ��%�B $,    �h%�C <,    ���D U,    ���E p,    � 4�F �,    � ��G �,    � |%�H �,    � R%�I  -    � ��J $-    � f�K H-    � ��L �-    ��&O �-    �*O �-    �y�P �-    ���P �-    �5�Q �-    �H�Q .    ��%&R '.    �&*R 4.    � �e S h.    ��/T �.    � 
 U 8/    ��%=U X/    ��%=W w/    �!�Y �/    ���Z �/    � UPZ �/    � \] �/    � gc_ 0    � " ` 0    � �e ` P0    ��ja t0    � 
 b �0    ��%pb �0    ��%pd /"    �! f �0    � D
~f  1    ���g 1    �! g      �� g      ���g      ��g      ���h      ���h      ���i      ���i      � �j      � �k      � 6#�l      � x#�m      � ��n $1    � ��o      � ��p @1    � � q      � �! r      � �#s \1    �!1s �1    �31t �1    �   u 2    �! u      ���u      ���u      �#�u      �^#�u      ���u 2    �]u '2    �! u 02    ��<u h2    �<v      �� w �2    � �Fw �2    � �	Px �2    � � y      � �!Fy      � [!Pz      � $^{      � �#d{ 3    �! {      �}�{ 3    �! { 3    �! { #3    �! {      �  {      � �{ +3    �! {      �
�{      �� �{      �[�{      ��{ 33    �! { ;3    �! {      ��"�{ D3    � �
{ d3    �t} �3    �8} �3    ��'} �3    ��3} �3    ��?} �3    � �e } $4    ��Q~ �4    ��%X �4    ��%X� 5    � 
 � �5    �t� �5    ��� �5    ��� �5    �%�� �5    �c  � �5    �t  � �5    � �e � (6    ���� �6    ��%�� �6    ��%�� �6    � 
 � !7    �! � ,7    � ��      � �!��      � �#�� Y7    � ��� i7    � ��      � �&� y7    �! � �7    ��� �7    ���� �7    ��� �7    ���� �7    ���� �7    ���� �7    ���� 
8    ���� 8    ���� .8    ���� 88    �C� R8    �Q� \8    �F� �8    ��� �8    ���� �8    ��2� �8    � 0V� �9    � %f� �9    � �$p� �9    � 6"y�      � ���      � s�� �9    ��� 
:    ��� :    ��*� .:    ��0� 8:    ��� R:    ��� \:    ��*� v:    ��0� �:    ��� �:    ��� �:    ��*� �:    ��0� �:    �! � �:    �
�� ;    ��� @;    �'�� x;    �8�� �;    �w�� �;    ����      �� � <    � �� )<    � ��� D<    � �$� t<    � z0� �<    � �0� �<    �  0�      � �##�      � �!�� 3=    � 6"� >=    � �$*�      � �2�      � s=�      � �J� H=    �! � P=    �C� j=    �S�� t=    ���� �=    ���� �=    ��	� �=    ��	�� �=    ���� �=    ���� �=    �! � �=    � ;!X� @>    � ;!m� �>    � "�� �>    � i$��      � "��      � �$��      � S��      � ��� �>    �! � �>    ��� �>    ���� �>    �\M� �>    �nS� ?    ���� "?    ���� ,?    �� �� F?    �� �� P?    ��M� j?    ��S� t?    ���� �?    ���� �?    �! � �?    �L/� �?    �f/�      �� � @    � � :� @    � � EF@    � � j P@    � � O[@    � gYx@    � �j     � �!Y
     � >$w     � �~     � �     � 5��@    �! �@    ��Q�@    ��M�@    ��SA    �! A    �+�HA    �D�     �\M     �� �A    � �S�A    �!    �   �"   Z   �   v    �    v    �    m   m   m   m      Q"         Q"   �      �         �   .      Q"   m   m   m   m   m   m   m   m   �   N      �   V
   V
   k   �   �   m   "   �   [
   �   "   �   o   "  �   "   "   V
   V
  �   V
  �   m   m   m   m   m   m   m   m   m  G  �  �%  l%  �  �   \   �  d   m   m   m   m   Z   �   �   �   �   �   "   �   [
 �   �   o  �   Z   �   �   �   �   �   V
   m   m   m   %   =   M#   �#      �   �   �"   �   m   m   m   m   �"   �"   �"   �"   z    �    Z   �   �   �   �   �   m   m   m   Z   �   �   �   �   �   �"   &   �   A      �   �   <   �   �   A      �   �   m   m   m   m   m   m     �   �   �    �"   8   �   8   �   �"   8   �   8   �   �"   m   m   m   m   m   m   m   m   m   m   m   m   c     �"   c   �"         �   �   c   �"   c   c     c   �"   c   m   m   m   m   !   S ^   �$   p   �   S ^ G   �$   G   p   �   ^   �"   �$   G   p   �   ^   p   x   p   �"   p   x   p   �$   G   p   �   ^   �"   �$   G   p   �   ^   m   m   m   m   m   m   m   m   G   �  �   �  �   �   �  !   �"   �    �   �   �"   G   �  �   �   �  !   m   m   m   � 
        8  8  6  : ) n , r  �  %  (%  e
# 1 M 9 �R 	 
 A !� I ! 	 ! I !� Q ! Y !� q ! y �	~$ ��� ! $ 	�, n&� �� , #�� � $ � $ +! $ @�� �%�$ � $ ! 4 	�< n&< #�4 ��� U 9 �%� � 7 "D ��D 	�L n&L #�D � � !� D ! 4 !  ��� F� n
V� sF9 ��� !� \ ~
�� !�� !� d � � !� � !-! y �	�| ! � ~
�� ! � ! � ~
�� ! � ! � ! � ! � ! � ! � ! 	 �e Y��� ! � ~
�� ! i�#i�%a��q!*a �� �$Ea�	�� �M� M! ~
�~
�~
�$! ,! � �#yPO� S� �%y�O4! <! aG�a��D~
�L! T! \~
�d! �!� �! �!$�! �!  T b X �  \ g ` l h b l �  p g t l x u | z �  � � � � � b � �  � g � u � � � � � � � b  �  g l u �
 ,b 0�  4g 8u <� Db H�  Lg Pl d�  hg lu qW �b ��  �g �u �� �� �� �� b �  g I� ]� a�' c� . C). CP. Cw. C�. C�. C�. C. C:. Ca. C�. C�. C�. C�. C$. CK. Cr. C�. C�. C�. C. C5. C\. C�. C�. C�. C. C.. C. K� . C�. C�. CH. Cd. C{. C�. C�. C�. C�. C. C . C<. Cd. Cz. C�. C�. C�. C�. C. C3. CY. Cq. C�. C�. C�. C. C2. CZ. C{. C�. C7. C7. Cw. C� . C� . C� . C!. C3!. CO!. Ci!. C�!. C�!. C�!. C�!. C". C;". C]". Cz". C�". C�". C�". C�". C#. CQ#. C{#. C�#. C�#. C�#. C�#. S"$. Cz . CP. CQ . C . C�. C�. C�. C�. C. C6. C[. Cu. C�. C�. C�. C�. C. C9. C^. C�. C�. C�. C�. C
. C-. CN. Cq. C�. C�. C�. C�. C- . [+$c C � c K � � c � � k � � c � � k � � [ � [ \s +)K��s ��K � �s �c � k � [  c � !k � !c � @c � Ak � Ac � `c � ac � ak � cC �cK�c�5c� � �c � ��� �K � K� � � #K�#C �#K � @� � C�5CK�CC �`� � �KV�s k�K � �C P�K � �s ��KV�C P�� � �C P�C i�K � �KV � � C Ps �K � KV � � #K � #s �@KVCs <	CK � `KVcs �	cK � �K � �s �	�K � �s +
�s n
�C P�KV�K � �C �
�� �  KV KV#� � #C �
)KVC�� CK � CC �
cK � cC �
�C �
�K � �C P�C =�KV�K � �C P�K � �s z�K � ��� KVC �C �C PK � �C S�C P�KV�K � �C P�s ��K � �K � ��� �K � �C 	C PC 	KVK � #C P#s �#K � CK � CC �CC `ak � ac � cC ��C ��K � �KV�C P�k � �c � �s ��K � �C P�K � KVK � C �C P#C P#s �#K � @� � `������K��k � �c � �K��k � �c � �c � �k �  	K	c � 	k �  	K@!	c � !	k � @	�d`	��	
K��
k � �
c � �
c � �
k � �
c � �
k � �c � �k � �c � �k � �k � �c � c � k � !c � !k � Ac � Ak � ac � ak � �k � �c � �c � �k � �k � �c � �k � �c � k � c � !c � !k � Ak � Ac � ak � ac � �k � �c � �k � �c � �c � �k � c � k � !k � !c � Ac � Ak � ac � ak � �c � �k � �k � �c � �c � �k � �k � �c �  ���c � �k � �k � �c � �� � �� � �KV KV@c � `c � �c � �c � �c � �c � �c � �c � �c �  c �  c � �� � �c �  c �  c � @c � `c � �c � �c � �c � �c �  c �  c � @c � �c � �c � �c �  c �  c � @c � `c � �c � �c � �c � �c �  c � � � � � � � � � � �!c �  "c �  "c � @"c � `"c � �"c � �"c � �"c �  $c � @$c � `$c � �$c � �$c � �$c � �$c �  %c �  %c � @%c � `%c � �%c � �&� � �'c � �'c � �(� �   J$
 I ] a x � w���?j��7v����"5x�;�Y!-9Eb������$8$f����IhG�dKn�      4  < 
 @    �.   {".    .   k.   :B   N    �   ?�   ��   m�   K�              	  
            "  #   $ $ % & ) ) * , / 0 2 1 < 2 > 3 @ 4 B 7 C : G ; J < M ? N @ P   �   �   h�   ��   ��   �  �  �  ��    N  �
  G  �  �%  l%  �  �  
E  �
  L
  
&E  �
  ��  �@  
  �D  �J  �
  �
  #
  b#
  �
  a  �@  �
  

  � 
  _
  
  �"
  �n  <s  �y  �  ��  �n  9�  x @  �n  �n  ��  �  ��  d�  J�  ��  �  �  �7  =  �7  =  �7  =  �@  Wn  ��  �	�  �  �n  �Z  ��  � �  �Z  ��  �@  �W  �Z  �Z  �@ ;   :      =   <   
      ?   >         A   @    	  � 
  � 
        �   �         �   �   3   �   �   9   �   �   J   K   /  .  V   U   A  B  X   W   Z   Y   [   \   ]   ^ !  _ #  ` %  h '  i '  k )  j )  l +  m +  o -  n -  v /  � 1  � 3  � 5  � 5  � 7  � 7  � 9  � 9  � ;  � =  � ?  � A  � C  � E  � G  � I  � K  � M  � O  � Q  � S  � U  � W  � Y  � [  � ]  � _  � _  � a  � a  � c  � c  � e  � e  � g  � g  � i  � i  � k  � k  � m  � m  � o  � o  � q  � s  � u  � w  � y  � y  � {  � {  � }  � }  �   �   � �  � �  � �  � �   �  �  �  �  �  �  �  �  �  !�  "�  $�  #�  %�  &�  '�  (�  )�  *�  +�  ,�  0�  =�  >�  ?�  C�  D�        ; #��
1J}OI�!�,��4	�	�	#
f
�
��rCw���A���]��                              �                  #                  :                  u                  T             n     [     [          $     M n    O n   � n] c� �� �s �] (] 3] ] �] �] %] � <  D        8    p0 Clamp01 IEnumerable`1 IEquatable`1 IntegratedSubsystem`1 Action`1 IntegratedSubsystemDescriptor`1 List`1 m_SubId1 id1 hash1 p1 UInt32 m_SubId2 id2 hash2 p2 Vector2 p3 Vector3 UInt64 Matrix4x4 <Module> get_disableBackbufferMSAA Texture2D m_UniqueID get_uniqueID set_uniqueID get_usePBufferEGL UnityEngine.XR UnityEngine.Experimental.XR GetNodeStates_Internal_WinRT screenX screenY value__ get_Camera set_Camera AvailableTrackingData mscorlib System.Collections.Generic GenerateMeshAsync desc get_Id set_Id s_InvalidId get_InvalidId m_DeviceId deviceId m_InstanceId instanceId get_TrackableId set_TrackableId planeId uniqueId get_MeshId set_MeshId InvalidMeshId meshId GetId referencePointId get_SubsumedById set_SubsumedById Head Add NodeAdded add_nodeAdded remove_nodeAdded add_PlaneAdded remove_PlaneAdded add_TrackingStateChanged remove_TrackingStateChanged Unchanged m_Tracked get_tracked set_tracked Interlocked Canceled analyticsEventRegistered TrackingAcquired add_trackingAcquired remove_trackingAcquired add_PointCloudUpdated remove_PointCloudUpdated add_PlaneUpdated remove_PlaneUpdated add_ReferencePointUpdated remove_ReferencePointUpdated PlaneEstimated GenerateMeshAsync_Injected TryGetPlane_Injected GetLocalRotation_Injected GetLocalPosition_Injected TryAddReferencePoint_Injected TryRemoveReferencePoint_Injected TryGetReferencePoint_Injected Internal_RaycastAsList_Injected Internal_GetBoundaryAsList_Injected Internal_RaycastAsFixedArray_Injected Internal_GetBoundaryAsFixedArray_Injected get_LightEstimationRequested set_LightEstimationRequested add_FrameReceived remove_FrameReceived NodeRemoved add_nodeRemoved remove_nodeRemoved add_PlaneRemoved remove_PlaneRemoved get_id set_id IsDeviceValid get_IsValid <Id>k__BackingField <TrackableId>k__BackingField <MeshId>k__BackingField <SubsumedById>k__BackingField <id>k__BackingField <Distance>k__BackingField <Plane>k__BackingField <subsystemImplementationType>k__BackingField <HitType>k__BackingField <Pose>k__BackingField <PreviousPose>k__BackingField <ChangeState>k__BackingField <TrackingState>k__BackingField <PreviousTrackingState>k__BackingField <NewState>k__BackingField <Size>k__BackingField <Mesh>k__BackingField <PlaneSubsystem>k__BackingField <MeshCollider>k__BackingField <Center>k__BackingField <Attributes>k__BackingField <Status>k__BackingField <Alignment>k__BackingField <PriorityHint>k__BackingField <ReferencePoint>k__BackingField LeftHand RightHand get_forward InputDevice get_Distance set_Distance Internal_InitializeManagedInstance CreateInstance GetConfidence TrackingReference GetHashCode get_supportsEditorMode GetDeviceIdAtXRNode GetDeviceAtXRNode node amplitude AddRange CompareExchange Invoke AngularAccelerationAvailable RotationAvailable PositionAvailable AngularVelocityAvailable Unavailable IDisposable SetHandle PrintExample UnityEngine.XRModule UnityEngine.CoreModule UnityEngine.PhysicsModule UnityEngine.UnityAnalyticsModule UnityEngine.SharedInternalsModule GetNodeName Internal_TryGetShaderName shaderName get_LastUpdatedFrame get_Plane set_Plane BoundedPlane removedPlane TryGetPlane plane Combine UnityEngine None m_Type get_nodeType set_nodeType TrackableType ValueType get_subsystemImplementationType set_subsystemImplementationType StaticAccessorType get_HitType set_HitType TrackingStateEventType eventType get_ProvidesAverageColorTemperature TryGetAverageColorTemperature averageColorTemperature SendHapticImpulse m_SupportsImpulse get_supportsImpulse set_supportsImpulse get_Pose set_Pose get_PreviousPose set_PreviousPose previousPose Dispose Create InvokeMeshReadyDelegate XRNodeState get_ChangeState set_ChangeState MeshChangeState DebuggerBrowsableState get_TrackingState set_TrackingState get_PreviousTrackingState set_PreviousTrackingState previousTrackingState get_NewState set_NewState newState onMeshGenerationComplete CompilerGeneratedAttribute UnverifiableCodeAttribute RequiredByNativeCodeAttribute UsedByNativeCodeAttribute DebuggableAttribute DebuggerBrowsableAttribute NativeNameAttribute NativeTypeAttribute NativeConditionalAttribute InternalsVisibleToAttribute NativeHeaderAttribute StaticAccessorAttribute FlagsAttribute RuntimeCompatibilityAttribute inValue outValue value Remove CenterEye LeftEye RightEye get_Size set_Size Mathf availabilityFlag System.Threading get_disablePositionalTracking set_disablePositionalTracking InputTracking ToString UnityEngine.Scripting get_Mesh mesh get_Width get_width obj trackableTypeMask hitMask Vertical get_Material set_Material get_Normal DestroyInstance_Internal GetNodeStates_Internal UnityEngine.Experimental Horizontal channel All UnityEngine.XRModule.dll GetBool ISubsystemDescriptorImpl get_Item System ISubsystem TSubsystem XRCameraSubsystem m_CameraSubsystem get_CameraSubsystem IntegratedSubsystem XRExampleSubsystem XRPlaneSubsystem get_PlaneSubsystem set_PlaneSubsystem planeSubsystem Internal_AddStandaloneSubsystem XRMeshSubsystem XRDepthSubsystem m_DepthSubsystem get_DepthSubsystem depthSubsystem XRSessionSubsystem get_SessionSubsystem XRReferencePointSubsystem XRRaycastSubsystem XRInputSubsystem XRDisplaySubsystem Enum fixedArrayIn Boolean Screen PlaneWithinPolygon Quaternion m_Session m_Acceleration m_AngularAcceleration TryGetAngularAcceleration set_angularAcceleration TryGetAcceleration set_acceleration duration m_Rotation GetLocalRotation TryGetRotation set_rotation op_Subtraction op_Addition m_Position GetLocalPosition TryGetPosition set_position ArgumentNullException ArgumentException Unknown MeshInfo SubsystemInfo Zero StaticConstructScriptingClassMap get_ProvidesTimestamp TryGetTimestamp Stop get_up Clear get_MeshCollider meshCollider SendHapticBuffer m_SupportsBuffer get_supportsBuffer set_supportsBuffer get_stereoscopicBackbuffer SubsystemManager other k_HashCodeMultiplier HardwareTracker GameController HashCodeHelper DotNetHelper get_Center set_Center Recenter UnknownError GetEnumerator Activator .ctor .cctor Internal_AddDescriptor Internal_InitializeManagedDescriptor ISubsystemDescriptor TSubsystemDescriptor get_SubsystemDescriptor XRCameraSubsystemDescriptor IntegratedSubsystemDescriptor XRExampleSubsystemDescriptor XRPlaneSubsystemDescriptor XRMeshSubsystemDescriptor XRDepthSubsystemDescriptor XRSessionSubsystemDescriptor XRReferencePointSubsystemDescriptor XRRaycastSubsystemDescriptor XRInputSubsystemDescriptor XRDisplaySubsystemDescriptor m_subsystemDescriptor descriptor m_Ptr instancePtr descriptorPtr IntPtr Internal_RemoveInstanceByPtr Internal_GetInstanceByPtr UnityEngine.Experimental.ISubsystemDescriptorImpl.ptr UnityEngine.Experimental.ISubsystemDescriptorImpl.get_ptr UnityEngine.Experimental.ISubsystemDescriptorImpl.set_ptr timestampNs UVs StopHaptics System.Diagnostics UnityEngine.Analytics m_AvailableFields PlaneWithinBounds InputDevices System.Runtime.CompilerServices Internal_ClearManagedInstances Internal_SubsystemInstances s_IntegratedSubsystemInstances s_StandaloneSubsystemInstances GetInstances instances DebuggingModes pointCloudRaycastAngleInDegrees TryGetHapticCapabilities capabilities GetAllPlanes planes GetTextures textures GetNodeStates nodeStates get_Attributes MeshVertexAttributes attributes UnityEngine.Bindings PlaneAddedEventArgs SessionTrackingStateChangedEventArgs PointCloudUpdatedEventArgs PlaneUpdatedEventArgs ReferencePointUpdatedEventArgs FrameReceivedEventArgs PlaneRemovedEventArgs lhs rhs NonAxis Normals Equals m_NumChannels get_numChannels set_numChannels TryGetMeshInfos meshInfos GetCorners Colors Internal_ClearManagedDescriptors Internal_SubsystemDescriptors s_IntegratedSubsystemDescriptors s_StandaloneSubsystemDescriptors GetSubsystemDescriptors descriptors Success get_ProvidesAverageBrightness TryGetAverageBrightness averageBrightness GenerationAlreadyInProgress hitResults Tangents GetAllReferencePoints get_SupportsFeaturePoints GetPoints get_Status MeshGenerationStatus RemoveAt Concat Format Object TryGet ret get_Height get_height get_right XRRaycastHit MeshGenerationResult AnalyticsResult result get_Alignment set_Alignment PlaneAlignment get_Current InvokePlaneAddedEvent InvokeTrackingStateChangedEvent InvokePointCloudUpdatedEvent InvokePlaneUpdatedEvent InvokeReferencePointUpdatedEvent InvokeFrameReceivedEvent InvokePlaneRemovedEvent SendEvent InvokeTrackingEvent RegisterEvent get_PriorityHint set_PriorityHint get_ReferencePoint set_ReferencePoint TryAddReferencePoint updatedReferencePoint TryRemoveReferencePoint TryGetReferencePoint referencePoint FeaturePoint screenPoint get_Count Start Raycast TryCopyFixedArrayToList Internal_GetPointCloudConfidenceAsList GetAllPlanesAsList GetTexturesAsList GetMeshInfosAsList Internal_GetPointCloudPointsAsList Internal_GetAllReferencePointsAsList Internal_RaycastAsList Internal_ScreenRaycastAsList Internal_GetBoundaryAsList inst TrackingLost add_trackingLost remove_trackingLost confidenceOut planesOut texturesOut meshInfosOut hitResultsOut referencePointsOut pointsOut listOut boundaryOut get_disablesLegacyInput MoveNext get_ProvidesProjectionMatrix TryGetProjectionMatrix projectionMatrix get_ProvidesDisplayMatrix TryGetDisplayMatrix displayMatrix Ray Internal_GetPointCloudConfidenceAsFixedArray GetAllPlanesAsFixedArray GetTexturesAsFixedArray GetMeshInfosAsFixedArray Internal_GetPointCloudPointsAsFixedArray Internal_GetAllReferencePointsAsFixedArray Internal_RaycastAsFixedArray Internal_ScreenRaycastAsFixedArray Internal_GetBoundaryAsFixedArray UnityEngineModuleAssembly op_Multiply Destroy TryGetPlaneBoundary TryGetBoundary get_Capacity set_Capacity m_Velocity m_AngularVelocity TryGetAngularVelocity set_angularVel