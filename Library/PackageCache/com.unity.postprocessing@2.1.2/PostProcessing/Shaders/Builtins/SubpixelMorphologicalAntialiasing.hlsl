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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           MZê       ˇˇ  ∏       @                                   Ä   ∫ ¥	Õ!∏LÕ!This program cannot be run in DOS mode.
$       PE  L             ‡ !  ¶         æ≈            @                                 @Ö                           l≈  O    ‡                                                                                             H           .text   ƒ•       ¶                    `.rsrc       ‡      ®              @  @.reloc            ¨              @  B                †≈      H     »A  §É                                                         0 ;      :   
8+   éio  
o  
<   o  
o  

8    * 0 3      r  p|  r  p(  
|  r  p(  
(  

8    * 0 ,      |  ˛  o  
|  ˛  o  
a
8    *0 #      u  9   •  (  +
8    * 0 -      {  {  @   {  {  ˛+
8    *   0 /       {  {  @    {  {  ˛+
8    * 0 2       {  {  @    {  {  ˛˛+
8    *  0       ~  
8    *  0       ˛  Ä  *(
  
* 0       {  (#  
8    *0       {  
8    *& }  *   0      {  
8    *"}  * 0      {  
8    *"}  *(  * 0 ;      {  ("  
(  •  å  9    å  }   8    *(  * 0 7   	   (  (  
u  •  
å  }  å  (  8    *n }  o.  ~  o  
* 0 `   
    ~  o  
8   (  

 t  ~  
}   (  
:⁄ˇˇˇ›   ˛  o  
‹~  o  
~  o  
*    0=     0 h      ~  o  
Y
8M    ~  o  
t  {  (  
9'    ~  o  
t  ~  
}  ~  o  
  Y
<¨ˇˇˇ*0 a       ~  o  
8'   (  
t  
 {  (  
9   ›'    (  
:Õˇˇˇ›   ˛  o  
‹8    *       =J     6 ~  o  
*Vs  
Ä  s  
Ä  *0 ¥       ~  o  
8   (  

 @   ›â    (  
:‹ˇˇˇ›   ˛  o  
‹~  o   
~	  :!    r  pddr9  pr;  p(!  
&Ä	   ˛  o  }  r  p	å  ~"  
(#  
&8    *    .;     R o  ~
  o$  
*   0 Q       ~
  o%  
8   (&  

 ~  
o   ('  
:ﬂˇˇˇ›   ˛	  o  
‹~
  o(  
*       +8     nÄ	  s*  
Ä
  s+  
Ä  * ()  *0 ™      o  
 ~
  o%  
8!   (&  

 u
  9   •
  o,  
 ('  
:”ˇˇˇ›   ˛	  o  
‹ ~  o  
8!   (  
 u
  9   •
  o,  
 (  
:”ˇˇˇ›   ˛  o  
‹*      7J      d 7õ     0 ™      o  
 ~  o  
8!   (  

 u
  9   •
  o,  
 (  
:”ˇˇˇ›   ˛  o  
‹ ~  o  
8!   (  
 u
  9   •
  o,  
 (  
:”ˇˇˇ›   ˛  o  
‹*      7J      d 7õ     0       {  
{  (  ((  *(-  *  0       {  •  
8    *(4  *0       {  •  
8    *0 (     ~  
  (-  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (/  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (-  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (/  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (-  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (/  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (-  
t  (  +
@ﬂˇˇˇ*0 (     ~  
  (/  
t  (  +
@ﬂˇˇˇ*0 ê      
˛  (V  (X  (Z  E      &         8,   ~  
87   ~  
8,   ~  
8!   ~  
8   rI  på  (0  
s1  
z9	    o2  
 *0 
      (S  *  0 
      (T  *Ç :    rü  ps4  
zo5  
(H  *fÄ  Ä  Ä  Ä  *   0       {4  
8    *& }4  *   0       {+  
8    *& }+  *   0       {3  ˛
8    *V 9   8   }3  *^ }-  %{,  `},  *^ }.  %{,  `},  *^ }/  %{,  `},  *^ }0  %{,  `},  *b }1  %{,  `},  *b }2  %{,   `},  *  0       {-  (  +
8    * 0       {.  (  +
8    * 0       {/  (  +
8    * 0       {0  (  +
8    * 0       {1  (  +
8    *0       {2   (  +
8    *0 ?      {3  @   {,  _>    Å
  
8    (  +Å
  
8    * 0       {5  
8    *& }5  *   0       {6  
8    *& }6  *   0       {7  
8    *& }7  *   0       {8  
8    *& }8  *   0 '      u  :   
8   •  (q  
8    * 0 Q      (h  (h  @5   (j  (j  @#   (l  (l  @   (n  (n  ˛+
8    *   0 d      (h  
 ˛#  o  
(j  ˛$  o  
ba(l  ˛$  o  
ca(n  ˛#  o  
ba8    *0        (q  
8    *   0       (s  ˛
8    *& }9  *   0       {9  (P  
8    *0       {9  (L  
8    * 0       {9  (M  
8    *  0       {9  (N  
8    *6 {9  (O  * 0 '      u  :   
8   •  (|  
8    * 0       {9  {9  ˛
8    *0       |9  ˛  o  

8    *  0        (|  
8    *   0       (~  ˛
8    * 0       (Q  
su  8    *  0       {:  
8    *(:  
* 0       (ë  
8    *j :   rµ  ps4  
z(ì  * 0 *     {;  
|;  (-  
t  (  +
@ﬁˇˇˇ*  0 *     {;  
|;  (/  
t  (  +
@ﬁˇˇˇ*  0 +      {;  9    {;   ˛   }:  o;  
 *(<  
* 0       {<  
8    *(=  
* 0 *     {=  
|=  (-  
t  (  +
@ﬁˇˇˇ*  0 *     {=  
|=  (/  
t  (  +
@ﬁˇˇˇ*j :   rÕ  ps4  
z(¶  *j :   r·  ps4  
z(ß  *0 +      {=  9    {=   ˛   }<  o>  
 *(?  
*(@  
*(A  
*(B  
*(C  
*(D  
*(E  
* 0        €¢˙ZX
8    *  0      {E  
8    *  0       {F  
8    *  0    !  {G  
8    *  0    "  {H  
8    *  0    #  {I  
8    *  0 '      u)  :   
8   •)  (¿  
8    * 0 ô   $   (∫  
 (∫  (  9u   (ª  (ª  oF  
9^   (º  (º  oF  
9G   (Ω  (Ω  å'  ˛'  oF  
9"   (æ  (æ  å*  ˛*  oF  
+8    	*   0        (¿  
8    *   0        (¿  ˛
8    *0 o   %   (∫  
 ˛  o  
(ª  o  
(π  (º  o  
(π  (Ω  ˛'  o  
(π  (æ  ˛*  o  
(π  8    	* 0      {U  
8    *"}U  * 0    &  {V  
8    *"}V  * 0      {W  
8    *"}W  * 0 '      u,  :   
8   •,  (À  
8    * 0 `   '   (ƒ  
 (ƒ  (  9<   (∆  (∆  å+  ˛+  oF  
9   (»  (»  (G  
+8    	*0        (À  
8    *   0        (À  ˛
8    *0 A   (   (ƒ  
 ˛  o  
(∆  ˛+  o  
(π  (»  (π  8    *(H  
*   0 !      :   r˝  ps4  
z(—  
8    *>(’  *> 9   oI  
*(J  
*   0      {]  
8    *"}]  * 0      {^  
8    *"}^  * 0    )  {_  
8    *"}_  * 0      {`  
8    *"}`  * 0    *  {a  
8    *"}a  * 0    +  {b  
8    *"}b  * 0    ,   (ﬂ  
 {K  
8    * 0    ,   (ﬂ  
 {L  
8    * 0    -   (€  
 (M  
8    * 0    .   (Â  (›  sN  

8    *  0 £   /   (€  (O  
(„  "   ?Z(P  

(€  (Q  
(‰  "   ?Z(P  
(›  (R  
(R  
Å  (›  (R  
(S  
Å  (›  (S  
(S  
Å  (›  (S  
(R  
Å  * 0 ,      :   r ps4  
z{\  (◊  (Í  
8    *&(Î  **(Ï  *   0    0  {c  
8    *"}c  * 0    1  {d  
8    *"}d  * 0    0  {e  
8    *"}e  * 0    1  {f  
8    *"}f  * 0    0  {g  
8    *"}g  * 0    1  {h  
8    *"}h  *(T  
* 0 *   2  {i  
|i  (-  
t!  (  +
@ﬁˇˇˇ*  0 *   2  {i  
|i  (/  
t!  (  +
@ﬁˇˇˇ*  0 *   3  {j  
|j  (-  
t"  (  +
@ﬁˇˇˇ*  0 *   3  {j  
|j  (/  
t"  (  +
@ﬁˇˇˇ*  0 *   4  {k  
|k  (-  
t#  (	  +
@ﬁˇˇˇ*  0 *   4  {k  
|k  (/  
t#  (	  +
@ﬁˇˇˇ**( *j :   r/ ps4  
z( *0 "      :   r ps4  
z(	 
8    *  0 3   5   {i  9&    {i   ˛1   (Ó   (  oU  
 * 0 3   6   {j  9&    {j   ˛2   (Ú   (Ù  oV  
 * 0 3   7   {k  9&    {k   ˛3   (ˆ   (¯  oW  
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
@ﬁˇˇˇ*  0 *   >  {  
|  (/  
t(  (
  +
@ﬁˇˇˇ*2(9 * 0       {a  
{b  
(1 
8    *&(: **(; *j :   rY ps4  
z(7 *  0 9   ?   {  9,   {   ˛;   ((  (*  (, oc  
*(d  
*   0    @   {Ñ  
8    * 0    <  {Ö  
8    *"}Ö  *(e  
* 0 *   A  {Ü  
|Ü  (-  
t+  (  +
@ﬁˇˇˇ*  0 *   A  {Ü  
|Ü  (/  
t+  (  +
@ﬁˇˇˇ*  0 3   B   {Ü  9&    {Ü   ˛?   }Ñ   (? of  
 *(g  
* BSJB         v2.0.50727     l   †6  #~  7  &  #Strings    (]  Ä  #US ®^     #GUID   ∏^  Ï$  #Blob         
W_∂	   ˙3 ƒ    7   A   Ü   F    
   l   5   £     B            Q   ê      ,                             ÿI f Ω  Ω eI  I ≥ I I ˛ Y" à á. E. ˆI ∂˛ I ;"    *I Î
I MA ,A  ˛ = I  I åæ fI
 ´ %
 ,% PI ¢˛ ˛ Ø˛ ¯I /I É I 
I
 í%
 ó%
 ∫ %
 Á %
 <% ˘% Ñ I
 ›%
 † %
 %
 %
 ß%
 ö#% Âà  $% s.” 8   >à !∆%    ƒ       Ä –7   	 W7   °   j÷   
 †   '÷   
 	  »÷   Å  ’÷   	  F ÷     P ÷   Ä «÷   Ä c÷ 	  ! â    % Å  v÷  % °   P÷   * 	  û÷  -   ' ÷<  2 Å  Ó÷  4 Å  1 ÷D  8 Å (  :   ⁄  Ö  U   O
(Ö  U    û(Ö # U 	 	( + U 	 m( 5 h 	 ï	( 9 u   {( : Ä 	 ú7 : Ç   f7> ; É   ¨7F < ò 	 L7 < û   ;7J = ü   87R > ™   Â7V > ¨   Ã7Z > ≠   ≤7^ > Æ   Ê7b > ±   ‘7f > ∂   ±7j > ∑   ¨7Ö > π Ä ¡7 D π 	 7 E ∫   ﬁ7Ö J ƒ   57Ö P ƒ 	 Ä7 U ƒ   +7v X œ   7~ X ÷   _7Ö X ◊ 	 Ò7 \ ◊ 	 7 c Ì 	 g7 e Ò 	 ≥7 g ı   ≈7Ç i ˘   7í l   W7Ö l 	 
7 u   ¡7ñ y   î7ö y  	 Ù 7 y !	 }7 | '  ß7û  -  p7¶ Ä <  º7Ö Ä =	 '7 Ñ =  7™ Ü @  S7≤ á F ˝B  m F  ä F  
∆  +  p „Ñ Ñ °È ÅÏ ¢Ù ¡  
∆  ÈÃ ÈÃ Á/ {"/  / k/Ä[VÄ·^VÄH^VÄ∫^VÄV"^Ä[VÄÑqVÄåqVÄzqVÄÿqVÄv	qVÄ	qVÄ≤qVÄ˚	qVÄ¢qÄ[VÄ1éVÄ¥
éVÄ¢
éVÄÕ
éVÄ∆
éVÄå
éVÄÖ
é 6q Wé ú ≈† 5%ú @%ú Aú Pú j[ Ò F  Ë gÈ $È ‹% F  x™ :ƒ L˙ Ä[VÄÁµ
VÄäµ
VÄ7µ
VÄòµ
VÄ¸µ
QÄç[! ıB ! }! ≥! 	µ
! ÈÄ[VÄ1VÄŸVÄ^VÄVÄ;Ä[VÄ%ãVÄ{ãVÄîãVÄ`ã ıB  Íã 8	[Ä[VÄÔ¡VÄx¡VÄ—¡ + ƒB  B  ∂∆ —ú gÀ 	¡ ì Y ì Y ì Y  K ?T è]Ä[VÄ1ÿVÄÿVÄiÿVÄ≤%ÿVÄÉÿVÄìÿVÄ!ÿVÄÿ ÿB  ∂∆ ? ùÿ ƒB  B ∂∆ V	› &B Ã∆ mÄ[VÄxBVÄBVÄﬂ
B 7F MB KeP     ñ C!-  ò     ∆ Y  ÿ     ∆ 
  !    ∆ ·e  @!    Ê·j  |!    ñò%p  ∏!    ñ§%p  ¯!    ñ	} 	 "    ë'Ç 	       ∆–π 	       ∆
Ω 	 /"    Ü! 
 8"    ÜúY 
 X"    ·	ûπ 
 s"    ·	ÿΩ 
 /"    Ñ!  Ä"    ÜúY  ö"    Ü£ã  §"    Üo æ"    Üè «"    Ü!  –"    Ü Í& #    Ü!   #    Ü Í& c#    ì ª	ô Ä#    ì ®Ç  ¸#    ì 1À p$    ì N› $    ì „ ˛$    ë'Ç  %    ì .+ ‰%    ì E8 ¸%    ì BÇ       ñ ÍQ      ñ üe l&    ë'Ç  à&    ë'Ç  ê&    ñ √Ä d'    ñ !Ä      ì ¶À      ì úÇ        ∆5!        ∆„        ∆$  /"    Ü!       É ˜
–      Ê5!       Ê„  8(    Ê$  ^(    Ü!  h(    Üî& /"    Ñ!        ∆5!        ∆„        ∆$  à(    Ñ!  ê(    Üî& ∞(    ñÀl ‰(    ñ‡l )    ñc"l L)    ñt"l Ä)    ñÎl ¥)    ñ˘l  Ë)    ñTl! *    ñdl" P*    ë A á# Ï*    ñ #ñ' +    ñ –∆(      ñ ÛÇ )      ñ ó) +    ñ ∂*      ë ø+      ë S:,      ñœ`,      ñÌá,      ì UØ-      ì ∑1      ì gø4      ì "«6      ì ™Ã7      ì 0
—8 ;+    ë'Ç 9      ë ‹◊9      ë ¬‡; X+    Ü¸ ®= s+    Ü	¨= Ä+    Ü=∂> õ+    ÜJª> ®+    Ütª? ∆+    ÜÄ¡? ‹+    ÜC∆@ Ù+    ÜÃA ,    Üã%∆B $,    Üh%∆C <,    Ü´∆D U,    ÜÄ∆E p,    Ü 4◊F î,    Ü ·„G ∏,    Ü |%◊H ‹,    Ü R%◊I  -    Ü ò◊J $-    Ü f◊K H-    Å ﬂıL î-    Üˆ&O Ø-    É*O º-    ÜyªP ◊-    Éç¡P ‰-    Ü5ªQ ˇ-    ÉH¡Q .    Ü%&R '.    É&*R 4.    ∆ ·e S h.    Ê·/T ».    ∆ 
 U 8/    ñò%=U X/    ñ§%=W w/    É!¨Y Ñ/    Ü∏ªZ §/    Ü UPZ »/    Ü \] Ï/    Ü gc_ 0    Ü " ` 0    ∆ ·e ` P0    Ê·ja t0    ∆ 
 b ú0    ñò%pb º0    ñ§%pd /"    Ü! f ‹0    ñ D
~f  1    Üä≥g 1    Ü! g      Ü» g      ÜÁªg      Ü¡g      ÜÅÃh      Üé“h      ÜàŸi      Üìﬂi      Ü Êj      Ü Êk      Ü 6#Ïl      Ü x#Ïm      Ü ”Ùn $1    Ü ¨˙o      Å £˙p @1    Ü ° q      Å ï! r      Å ‰#s \1    Ü!1s î1    Ü31t Ã1    Å   u 2    Ü! u      ÜÔªu      Ü˚ªu      Ü#ªu      Ü^#ªu      ÜΩªu 2    Ü]u '2    Ü! u 02    Ü¯<u h2    Ü<v      Ü» w û2    Ü óFw π2    Ü Ì	Px ‘2    Å ∞ y      Å ∫!Fy      Å [!Pz      Å $^{      Å û#d{ 3    Ü! {      Ü}ª{ 3    Ü! { 3    Ü! { #3    Ü! {      Ü  {      Ü ª{ +3    Ü! {      Ü
ª{      ÜÕ ª{      Ü[ª{      Üª{ 33    Ü! { ;3    Ü! {      Ü¯"ª{ D3    ñ Û
{ d3    Üt} Ä3    Ü8} ú3    Üı'} ∏3    Ü°3} ‘3    Üœ?} 3    ∆ ·e } $4    Ê·Q~ Ã4    ñò%X Ï4    ñ§%XÅ 5    ∆ 
 É à5    ÜtÉ ¢5    ÜòÉ ¨5    Ü§Ñ ∆5    Ü%™Ñ –5    Üc  Ö Í5    Üt  Ö Ù5    ∆ ·e Ü (6    Ê·¿á î6    ñò%«à ¥6    ñ§%«ä ‘6    ∆ 
 å !7    Ü! å ,7    Ü Ëå      Å ß!Ëç      Å ¸#Ûé Y7    Ü ÿ˙é i7    Å Òì      Å í&ï y7    Ü! ö Ñ7    ÜÔö û7    Üˆòö ®7    Ü∂õ ¬7    Ü«òõ Ã7    Ü°÷ú Ê7    Ü™‹ú 7    Ü›„ù 
8    ÜË∆ù 8    ÜïÓû .8    ÜûÙû 88    ÜCü R8    ÜQü \8    ÜF† Ä8    ÜÍ† §8    Üõ„† »8    Ü›2† 8    Ü 0V† †9    Ü %f§ ÿ9    ë ©$p• ‚9    ë 6"yß      ë ΩÜ™      ë sê¨ 9    Ü÷Ø 
:    ÉÈØ :    Ü›*∞ .:    ÉÁ0∞ 8:    Ü÷± R:    ÉÈ± \:    Ü›*≤ v:    ÉÁ0≤ Ä:    Ü÷≥ ö:    ÉÈ≥ §:    Ü›*¥ æ:    ÉÁ0¥ «:    Ü! µ –:    Ü
âµ ;    Üâ∂ @;    Ü'∑∑ x;    Ü8∑∏ ∞;    ÜwÂπ Ë;    ÜàÂ∫      Ü» ª <    Ü ª )<    Ü ç˙Ω D<    Ü ¯$æ t<    Å z0¿ ¥<    Å Õ0¡ Ù<    Å  0¬      Å À##√      Å Ç!˙√ 3=    Å 6"ƒ >=    Å ©$*∆      Å ≠2«      Å s=…      Å ΩJÀ H=    Ü! Ã P=    ÜCÃ j=    ÜSòÃ t=    Ü°÷Õ é=    Ü™‹Õ ò=    Ü°	Œ ≤=    ÜÆ	ÎŒ º=    Ü¬ˆœ ÷=    ÜŒ¸œ ﬂ=    Ü! – Ë=    Ü ;!X– @>    ñ ;!m” ö>    ë "âŸ ™>    ë i$ùﬂ      Å "≠‰      Å Ü$ΩË      ë S…Î      ë óﬁÒ ∏>    Ü! ˆ ¿>    ÜÔˆ ⁄>    Éˆòˆ ‰>    Ü\M˜ ˛>    ÉnS˜ ?    Ü°÷¯ "?    É™‹¯ ,?    ÜÖ Ë˘ F?    Éò Ó˘ P?    ÜÄM˙ j?    ÉöS˙ t?    Ü≥÷˚ é?    Éƒ‹˚ ó?    Ü! ¸ †?    ÜL/¸ ÿ?    Üf/˝      Ü» ˛ @    Ü ´ :˛ @    Ü ´ EF@    Ü ÷ j P@    Ü Ó O[@    Ü gYx@    Å Âj     Å ›!Y
     Å >$w     Å ˆ~     Å ã     Å 5íΩ@    Ü! »@    ÜíQ‰@    Ü M˛@    Ü◊SA    Ü! A    Ü+ëHA    ÜDë     Ü\M     Ü» ÄA    Å êSøA    Ü!    ˝   ‰"   Z   á   v    ì    v    ì    m   m   m   m      Q"         Q"   ˇ      Í         €   .      Q"   m   m   m   m   m   m   m   m   Ò   N      Ñ   V
   V
   k   ƒ   ƒ   m   "   ˙   [
   º   "   ˙   o   "  Ä   "   "   V
   V
  Ê   V
  Ê   m   m   m   m   m   m   m   m   m  G  Ù  è%  l%  Ø  Ñ   \   ≠  d   m   m   m   m   Z   á   ≤   ª   ≤   ª   "   ˙   [
 º   ˙   o  Ä   Z   á   ≤   ª   ≤   ª   V
   m   m   m   %   =   M#   å#      Ω   Ω   †"   ≠   m   m   m   m   ⁄"   à"   ⁄"   à"   z    ó    Z   á   …   Õ   …   Õ   m   m   m   Z   á   …   Õ   …   Õ   ¨"   &   ò   A      Û   Ì   <   Ì   ò   A      Û   Ì   m   m   m   m   m   m     Ä   ù   ®    Ï"   8   ¡   8   ¡   Ï"   8   ¡   8   ¡   Ï"   m   m   m   m   m   m   m   m   m   m   m   m   c     ñ"   c   Ï"         ˛   ö   c   Ï"   c   c     c   Ï"   c   m   m   m   m   !   S ^   ∆$   p   ¸   S ^ G   ∆$   G   p   ¸   ^   π"   ∆$   G   p   ¸   ^   p   x   p   π"   p   x   p   ∆$   G   p   ¸   ^   π"   ∆$   G   p   ¸   ^   m   m   m   m   m   m   m   m   G   Ù  •   Â  •   •   •  !   «"   ¿    ¥   ’   «"   G   Ù  •   •   •  !   m   m   m   ‰ 
        8  8  6  : ) n , r  Ô  %  (%  e
# 1 M 9 —R 	 
 A !ã I ! 	 ! I !ã Q ! Y !Û q ! y ﬁ	~$ ›ìÅ ! $ 	´, n&ë ó∆ , #ªô ‚ $ Ô $ +! $ @øë ò%≈$ ¡ $ ! 4 	´< n&< #ª4 ›ì° U 9 ÷% ° 7 "D ›ìD 	´L n&L #ªD Ô ± !ã D ! 4 !  ›ì¡ F… n
V¡ sF9  Å— !ã \ ~
ì± !ùÈ !ã d Ô Ò !ã ˘ !-! y ﬁ	Í| ! Ñ ~
ìå ! î ! ú ~
ì§ ! ¨ ! ¥ ! º ! ƒ ! Ã ! ‘ ! 	 ·e Y·ªÏ ! Ù ~
ì¸ ! iò#i⁄%aË„q!*a „Ÿ ‰$Eaâ	„Ÿ ˝MŸ M! ~
ì~
ì~
ì$! ,! Ÿ ò#yPOÅ SŸ ⁄%yıO4! <! aGúaÙ†D~
ìL! T! \~
ìd! ë!ã ô! °!$±! π!  T b X ¥  \ g ` l h b l ¥  p g t l x u | z Ä  Ñ Ñ à â ê b î ¥  ò g ú u † â § í ® ó ¸ b  ¥  g l u Ó
 ,b 0¥  4g 8u <â Db H¥  Lg Pl d¥  hg lu qW ¥b ∏¥  ºg ¿u ƒâ »› Ãí –‚ b ¥  g I‚ ]‚ aÑ' c¥ . C). CP. Cw. Cû. C≈. CÏ. C. C:. Ca. Cà. CØ. C÷. C˝. C$. CK. Cr. Cô. C¿. CÁ. C. C5. C\. CÜ. C∞. C⁄. C. C.. C. K¥ . C€. Cï. CH. Cd. C{. Cö. CØ. C . CÍ. C. C . C<. Cd. Cz. Cã. C£. C«. C„. C. C3. CY. Cq. Cì. Cª. CÔ. C. C2. CZ. C{. C¥. C7. C7. Cw. C° . CÕ . C˚ . C!. C3!. CO!. Ci!. Cè!. C´!. CŒ!. Cı!. C". C;". C]". Cz". Có". C∑". C◊". C˘". C#. CQ#. C{#. Cï#. CØ#. C…#. CÔ#. S"$. Cz . CP. CQ . C . Cì. Cπ. Cÿ. C¯. C. C6. C[. Cu. Cí. C±. C’. CÒ. C. C9. C^. CÇ. C£. C√. CË. C
. C-. CN. Cq. Cí. C±. C÷. Cı. C- . [+$c C ê c K ¥ ° c ¥ ° k ˘ ¡ c ¥ ¡ k ˘ √ [ — [ \s +)KÙ£s û„K ¥ „s ÷c ¥ k ˘ [  c ¥ !k ˘ !c ¥ @c ¥ Ak ˘ Ac ¥ `c ¥ ac ¥ ak ˘ cC ÌcKÙcª5cã ¥ Äc ¥ √√¥ „K ¥ KÙ ã ¥ #KÙ#C Ì#K ¥ @ã ¥ Cª5CKÙCC Ì`ã ¥ ÉKVÉs kÉK ¥ ÉC P£K ¥ £s ±£KV£C P‡ã ¥ „C P„C i„K ¥ „KV ã ¥ C Ps §K ¥ KV ã ¥ #K ¥ #s Û@KVCs <	CK ¥ `KVcs è	cK ¥ ÉK ¥ És ÿ	£K ¥ £s +
√s n
√C P√KV√K ¥ „C ∫
„ã ¥  KV KV#ã ¥ #C ∫
)KVC√¥ CK ¥ CC ∫
cK ¥ cC ∫
ÉC ∫
ÉK ¥ £C P£C =£KV£K ¥ √C P√K ¥ √s z„K ¥ „√¥ KVC ÌC ∫C PK ¥ ÉC SÉC PÉKVÉK ¥ £C P£s ê£K ¥ √K ¥ √√¥ „K ¥ „C 	C PC 	KVK ¥ #C P#s ˜#K ¥ CK ¥ CC •CC `ak ˘ ac ¥ cC •ÉC ùÉK ¥ ÉKVÉC P°k ˘ °c ¥ £s Ï£K ¥ £C P√K ¥ KVK ¥ C •C P#C P#s Ï#K ¥ @ã ¥ `õ£ÄõÕ†KÙ°k ˘ °c ¥ ¿KÙ¡k ˘ ¡c ¥ ·c ¥ ·k ˘  	K	c ¥ 	k ˘  	K@!	c ¥ !	k ˘ @	≥d`	≥å	
K¢°
k ˘ °
c ¥ ¡
c ¥ ¡
k ˘ ·
c ¥ ·
k ˘ °c ¥ °k ˘ ¡c ¥ ¡k ˘ ·k ˘ ·c ¥ c ¥ k ˘ !c ¥ !k ˘ Ac ¥ Ak ˘ ac ¥ ak ˘ Åk ˘ Åc ¥ °c ¥ °k ˘ ¡k ˘ ¡c ¥ ·k ˘ ·c ¥ k ˘ c ¥ !c ¥ !k ˘ Ak ˘ Ac ¥ ak ˘ ac ¥ °k ˘ °c ¥ ¡k ˘ ¡c ¥ ·c ¥ ·k ˘ c ¥ k ˘ !k ˘ !c ¥ Ac ¥ Ak ˘ ac ¥ ak ˘ Åc ¥ Åk ˘ °k ˘ °c ¥ ¡c ¥ ¡k ˘ ·k ˘ ·c ¥  õÖ°c ¥ °k ˘ ¡k ˘ ¡c ¥ ‡ã ¥ †ã ¥ ‡KV KV@c ¥ `c ¥ Äc ¥ †c ¥ ¿c ¥ Äc ¥ †c ¥ ¿c ¥ ‡c ¥  c ¥  c ¥ Äã ¥ ‡c ¥  c ¥  c ¥ @c ¥ `c ¥ Äc ¥ †c ¥ ¿c ¥ ‡c ¥  c ¥  c ¥ @c ¥ †c ¥ ¿c ¥ ‡c ¥  c ¥  c ¥ @c ¥ `c ¥ Äc ¥ †c ¥ ¿c ¥ ‡c ¥  c ¥ Ä ã ¥ † ã ¥ ¿ ã ¥ ‡!c ¥  "c ¥  "c ¥ @"c ¥ `"c ¥ Ä"c ¥ †"c ¥ ¿"c ¥  $c ¥ @$c ¥ `$c ¥ Ä$c ¥ †$c ¥ ¿$c ¥ ‡$c ¥  %c ¥  %c ¥ @%c ¥ `%c ¥ Ä%c ¥ ¿&ã ¥ ¿'c ¥ ‡'c ¥ †(ã ¥   J$
 I ] a x … w†–¸?jã˝7vë¡§±"5xÆ;˛Y!-9Ebû±—–Ë˚$8$fî¬ÁIhG‚dKnú      4  < 
 @    Á.   {".    .   k.   :B   N    Ü   ?ä   èé   m¢   KÆ              	  
            "  #   $ $ % & ) ) * , / 0 2 1 < 2 > 3 @ 4 B 7 C : G ; J < M ? N @ P   Ü   ¬   h¬   ¡Õ   ¡Õ   ì  ’  ’  ÒÈ    N  Ñ
  G  Ù  è%  l%  Ø  Ñ  
E  ë
  L
  
&E  º
  é∏  Ã@  
  íD  óJ  Û
  ˇ
  #
  b#
  ¡
  a  Ã@  Å
  

  — 
  _
  
  ¸"
  ën  <s  ˘y  ∫  ËÖ  ën  9⁄  x @  ’n  Àn  ›û  Ï  ¢§  d™  J∞  Ó∞  ü  ¥  Ì7  =  Ì7  =  Ì7  =  Ã@  Wn  ›û  ≤	∞  “  ’n  ºZ  ›û  Ù ı  ûZ  »û  Ã@  ñW  €Z  ºZ  Ã@ ;   :      =   <   
      ?   >         A   @    	  ï 
  ñ 
        †   °         ˚   ˙   3   ˝   ¸   9   ˇ   ˛   J   K   /  .  V   U   A  B  X   W   Z   Y   [   \   ]   ^ !  _ #  ` %  h '  i '  k )  j )  l +  m +  o -  n -  v /  Ç 1  Ñ 3  Ü 5  Ö 5  á 7  à 7  â 9  ä 9  ô ;  ö =  õ ?  ú A  ù C  û E  ¢ G  ´ I  ≤ K  ≥ M  ¥ O  µ Q  ∏ S  ∫ U  ª W  º Y  Ω [  æ ]  ƒ _  ≈ _  ∆ a  « a  » c  … c  ÿ e  ◊ e  Ÿ g  ⁄ g  € i  ‹ i  › k  ﬁ k  ﬂ m  ‡ m  ‚ o  · o  „ q  ‰ s  Â u  Ê w  Ó y  Ì y   {  Ô {  Ú }  Ò }  Ù   Û   ˆ Å  ı Å  ¯ É  ˜ É   Ö  á  á  â  â  ã  ã  ç  ç  !è  "è  $ë  #ë  %ì  &ì  'ï  (ï  )ó  *ó  +ô  ,ô  0õ  =ù  >ü  ?ü  C°  D£        ; #å¥
1J}OIΩ!™,ùÎ4	á	–	#
f
˘
ê‡rCw•”àAÔ˚‰]‰Ä                              ¥                  #                  :                  u                  T             n     [     [          $     M n    O n   œ n] cŒ “Œ ﬁs ] (] 3] ] ≠] €] %] á <  D        8    p0 Clamp01 IEnumerable`1 IEquatable`1 IntegratedSubsystem`1 Action`1 IntegratedSubsystemDescriptor`1 List`1 m_SubId1 id1 hash1 p1 UInt32 m_SubId2 id2 hash2 p2 Vector2 p3 Vector3 UInt64 Matrix4x4 <Module> get_disableBackbufferMSAA Texture2D m_UniqueID get_uniqueID set_uniqueID get_usePBufferEGL UnityEngine.XR UnityEngine.Experimental.XR GetNodeStates_Internal_WinRT screenX screenY value__ get_Camera set_Camera AvailableTrackingData mscorlib System.Collections.Generic GenerateMeshAsync desc get_Id set_Id s_InvalidId get_InvalidId m_DeviceId deviceId m_InstanceId instanceId get_TrackableId set_TrackableId planeId uniqueId get_MeshId set_MeshId InvalidMeshId meshId GetId referencePointId get_SubsumedById set_SubsumedById Head Add NodeAdded add_nodeAdded remove_nodeAdded add_PlaneAdded remove_PlaneAdded add_TrackingStateChanged remove_TrackingStateChanged Unchanged m_Tracked get_tracked set_tracked Interlocked Canceled analyticsEventRegistered TrackingAcquired add_trackingAcquired remove_trackingAcquired add_PointCloudUpdated remove_PointCloudUpdated add_PlaneUpdated remove_PlaneUpdated add_ReferencePointUpdated remove_ReferencePointUpdated PlaneEstimated GenerateMeshAsync_Injected TryGetPlane_Injected GetLocalRotation_Injected GetLocalPosition_Injected TryAddReferencePoint_Injected TryRemoveReferencePoint_Injected TryGetReferencePoint_Injected Internal_RaycastAsList_Injected Internal_GetBoundaryAsList_Injected Internal_RaycastAsFixedArray_Injected Internal_GetBoundaryAsFixedArray_Injected get_LightEstimationRequested set_LightEstimationRequested add_FrameReceived remove_FrameReceived NodeRemoved add_nodeRemoved remove_nodeRemoved add_PlaneRemoved remove_PlaneRemoved get_id set_id IsDeviceValid get_IsValid <Id>k__BackingField <TrackableId>k__BackingField <MeshId>k__BackingField <SubsumedById>k__BackingField <id>k__BackingField <Distance>k__BackingField <Plane>k__BackingField <subsystemImplementationType>k__BackingField <HitType>k__BackingField <Pose>k__BackingField <PreviousPose>k__BackingField <ChangeState>k__BackingField <TrackingState>k__BackingField <PreviousTrackingState>k__BackingField <NewState>k__BackingField <Size>k__BackingField <Mesh>k__BackingField <PlaneSubsystem>k__BackingField <MeshCollider>k__BackingField <Center>k__BackingField <Attributes>k__BackingField <Status>k__BackingField <Alignment>k__BackingField <PriorityHint>k__BackingField <ReferencePoint>k__BackingField LeftHand RightHand get_forward InputDevice get_Distance set_Distance Internal_InitializeManagedInstance CreateInstance GetConfidence TrackingReference GetHashCode get_supportsEditorMode GetDeviceIdAtXRNode GetDeviceAtXRNode node amplitude AddRange CompareExchange Invoke AngularAccelerationAvailable RotationAvailable PositionAvailable AngularVelocityAvailable Unavailable IDisposable SetHandle PrintExample UnityEngine.XRModule UnityEngine.CoreModule UnityEngine.PhysicsModule UnityEngine.UnityAnalyticsModule UnityEngine.SharedInternalsModule GetNodeName Internal_TryGetShaderName shaderName get_LastUpdatedFrame get_Plane set_Plane BoundedPlane removedPlane TryGetPlane plane Combine UnityEngine None m_Type get_nodeType set_nodeType TrackableType ValueType get_subsystemImplementationType set_subsystemImplementationType StaticAccessorType get_HitType set_HitType TrackingStateEventType eventType get_ProvidesAverageColorTemperature TryGetAverageColorTemperature averageColorTemperature SendHapticImpulse m_SupportsImpulse get_supportsImpulse set_supportsImpulse get_Pose set_Pose get_PreviousPose set_PreviousPose previousPose Dispose Create InvokeMeshReadyDelegate XRNodeState get_ChangeState set_ChangeState MeshChangeState DebuggerBrowsableState get_TrackingState set_TrackingState get_PreviousTrackingState set_PreviousTrackingState previousTrackingState get_NewState set_NewState newState onMeshGenerationComplete CompilerGeneratedAttribute UnverifiableCodeAttribute RequiredByNativeCodeAttribute UsedByNativeCodeAttribute DebuggableAttribute DebuggerBrowsableAttribute NativeNameAttribute NativeTypeAttribute NativeConditionalAttribute InternalsVisibleToAttribute NativeHeaderAttribute StaticAccessorAttribute FlagsAttribute RuntimeCompatibilityAttribute inValue outValue value Remove CenterEye LeftEye RightEye get_Size set_Size Mathf availabilityFlag System.Threading get_disablePositionalTracking set_disablePositionalTracking InputTracking ToString UnityEngine.Scripting get_Mesh mesh get_Width get_width obj trackableTypeMask hitMask Vertical get_Material set_Material get_Normal DestroyInstance_Internal GetNodeStates_Internal UnityEngine.Experimental Horizontal channel All UnityEngine.XRModule.dll GetBool ISubsystemDescriptorImpl get_Item System ISubsystem TSubsystem XRCameraSubsystem m_CameraSubsystem get_CameraSubsystem IntegratedSubsystem XRExampleSubsystem XRPlaneSubsystem get_PlaneSubsystem set_PlaneSubsystem planeSubsystem Internal_AddStandaloneSubsystem XRMeshSubsystem XRDepthSubsystem m_DepthSubsystem get_DepthSubsystem depthSubsystem XRSessionSubsystem get_SessionSubsystem XRReferencePointSubsystem XRRaycastSubsystem XRInputSubsystem XRDisplaySubsystem Enum fixedArrayIn Boolean Screen PlaneWithinPolygon Quaternion m_Session m_Acceleration m_AngularAcceleration TryGetAngularAcceleration set_angularAcceleration TryGetAcceleration set_acceleration duration m_Rotation GetLocalRotation TryGetRotation set_rotation op_Subtraction op_Addition m_Position GetLocalPosition TryGetPosition set_position ArgumentNullException ArgumentException Unknown MeshInfo SubsystemInfo Zero StaticConstructScriptingClassMap get_ProvidesTimestamp TryGetTimestamp Stop get_up Clear get_MeshCollider meshCollider SendHapticBuffer m_SupportsBuffer get_supportsBuffer set_supportsBuffer get_stereoscopicBackbuffer SubsystemManager other k_HashCodeMultiplier HardwareTracker GameController HashCodeHelper DotNetHelper get_Center set_Center Recenter UnknownError GetEnumerator Activator .ctor .cctor Internal_AddDescriptor Internal_InitializeManagedDescriptor ISubsystemDescriptor TSubsystemDescriptor get_SubsystemDescriptor XRCameraSubsystemDescriptor IntegratedSubsystemDescriptor XRExampleSubsystemDescriptor XRPlaneSubsystemDescriptor XRMeshSubsystemDescriptor XRDepthSubsystemDescriptor XRSessionSubsystemDescriptor XRReferencePointSubsystemDescriptor XRRaycastSubsystemDescriptor XRInputSubsystemDescriptor XRDisplaySubsystemDescriptor m_subsystemDescriptor descriptor m_Ptr instancePtr descriptorPtr IntPtr Internal_RemoveInstanceByPtr Internal_GetInstanceByPtr UnityEngine.Experimental.ISubsystemDescriptorImpl.ptr UnityEngine.Experimental.ISubsystemDescriptorImpl.get_ptr UnityEngine.Experimental.ISubsystemDescriptorImpl.set_ptr timestampNs UVs StopHaptics System.Diagnostics UnityEngine.Analytics m_AvailableFields PlaneWithinBounds InputDevices System.Runtime.CompilerServices Internal_ClearManagedInstances Internal_SubsystemInstances s_IntegratedSubsystemInstances s_StandaloneSubsystemInstances GetInstances instances DebuggingModes pointCloudRaycastAngleInDegrees TryGetHapticCapabilities capabilities GetAllPlanes planes GetTextures textures GetNodeStates nodeStates get_Attributes MeshVertexAttributes attributes UnityEngine.Bindings PlaneAddedEventArgs SessionTrackingStateChangedEventArgs PointCloudUpdatedEventArgs PlaneUpdatedEventArgs ReferencePointUpdatedEventArgs FrameReceivedEventArgs PlaneRemovedEventArgs lhs rhs NonAxis Normals Equals m_NumChannels get_numChannels set_numChannels TryGetMeshInfos meshInfos GetCorners Colors Internal_ClearManagedDescriptors Internal_SubsystemDescriptors s_IntegratedSubsystemDescriptors s_StandaloneSubsystemDescriptors GetSubsystemDescriptors descriptors Success get_ProvidesAverageBrightness TryGetAverageBrightness averageBrightness GenerationAlreadyInProgress hitResults Tangents GetAllReferencePoints get_SupportsFeaturePoints GetPoints get_Status MeshGenerationStatus RemoveAt Concat Format Object TryGet ret get_Height get_height get_right XRRaycastHit MeshGenerationResult AnalyticsResult result get_Alignment set_Alignment PlaneAlignment get_Current InvokePlaneAddedEvent InvokeTrackingStateChangedEvent InvokePointCloudUpdatedEvent InvokePlaneUpdatedEvent InvokeReferencePointUpdatedEvent InvokeFrameReceivedEvent InvokePlaneRemovedEvent SendEvent InvokeTrackingEvent RegisterEvent get_PriorityHint set_PriorityHint get_ReferencePoint set_ReferencePoint TryAddReferencePoint updatedReferencePoint TryRemoveReferencePoint TryGetReferencePoint referencePoint FeaturePoint screenPoint get_Count Start Raycast TryCopyFixedArrayToList Internal_GetPointCloudConfidenceAsList GetAllPlanesAsList GetTexturesAsList GetMeshInfosAsList Internal_GetPointCloudPointsAsList Internal_GetAllReferencePointsAsList Internal_RaycastAsList Internal_ScreenRaycastAsList Internal_GetBoundaryAsList inst TrackingLost add_trackingLost remove_trackingLost confidenceOut planesOut texturesOut meshInfosOut hitResultsOut referencePointsOut pointsOut listOut boundaryOut get_disablesLegacyInput MoveNext get_ProvidesProjectionMatrix TryGetProjectionMatrix projectionMatrix get_ProvidesDisplayMatrix TryGetDisplayMatrix displayMatrix Ray Internal_GetPointCloudConfidenceAsFixedArray GetAllPlanesAsFixedArray GetTexturesAsFixedArray GetMeshInfosAsFixedArray Internal_GetPointCloudPointsAsFixedArray Internal_GetAllReferencePointsAsFixedArray Internal_RaycastAsFixedArray Internal_ScreenRaycastAsFixedArray Internal_GetBoundaryAsFixedArray UnityEngineModuleAssembly op_Multiply Destroy TryGetPlaneBoundary TryGetBoundary get_Capacity set_Capacity m_Velocity m_AngularVelocity TryGetAngularVelocity set_angularVel