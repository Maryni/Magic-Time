ing for target area.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoAspectRatio.Stretch">
      <summary>
        <para>Resize non-proportionally to fit the target area.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoAudioOutputMode">
      <summary>
        <para>Places where the audio embedded in a video can be sent.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoAudioOutputMode.APIOnly">
      <summary>
        <para>Send the embedded audio to the associated AudioSampleProvider.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoAudioOutputMode.AudioSource">
      <summary>
        <para>Send the embedded audio into a specified AudioSource.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoAudioOutputMode.Direct">
      <summary>
        <para>Send the embedded audio direct to the platform's audio hardware.</para>
      </summary>
    </member>
    <member name="F:UnityEngine.Video.VideoAudioOutputMode.None">
      <summary>
        <para>Disable the embedded audio.</para>
      </summary>
    </member>
    <member name="T:UnityEngine.Video.VideoClip">
      <summary>
        <para>A container for video data.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.audioTrackCount">
      <summary>
        <para>Number of audio tracks in the clip.</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.frameCount">
      <summary>
        <para>The length of the VideoClip in frames. (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.frameRate">
      <summary>
        <para>The frame rate of the clip in frames/second. (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.height">
      <summary>
        <para>The height of the images in the video clip in pixels. (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.length">
      <summary>
        <para>The length of the video clip in seconds. (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.originalPath">
      <summary>
        <para>The video clip path in the project's assets. (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.pixelAspectRatioDenominator">
      <summary>
        <para>Denominator of the pixel aspect ratio (num:den). (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.pixelAspectRatioNumerator">
      <summary>
        <para>Numerator of the pixel aspect ratio (num:den). (Read Only).</para>
      </summary>
    </member>
    <member name="P:UnityEngine.Video.VideoClip.width">
      <summary>
        <para>The width of the images in the video clip in pixels. (Read Only).</para>
      </summary>
    </member>
    <member name="M:UnityEngine.Video.VideoClip.GetAudioChannelCount(System.UInt16)">
      <summary>
        <para>The number of channels in the audio track.  E.g. 2 for a stereo track.</para>
      </summary>
      <param name="audioTrackIdx">Index of the audio queried audio track.</param>
      <returns>
        <para>The number of channels.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoClip.GetAudioLanguage(System.UInt16)">
      <summary>
        <para>Get the audio track language.  Can be unknown.</para>
      </summary>
      <param name="audioTrackIdx">Index of the audio queried audio track.</param>
      <returns>
        <para>The abbreviated name of the language.</para>
      </returns>
    </member>
    <member name="M:UnityEngine.Video.VideoClip.GetAudioSampleRate(System.UInt16)">
      <summary>
        <para>Get the audio track sampling rate in Hertz.</para>
      </summary>
      <param name="audioTrackIdx">Index of the audio queried audio track.</param>
      <returns>
        <para>The sampling rate in Hertz.</para>
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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ¶˝#&ËE2       CPµd¥gºKÅùÄTU∏ô  p   [     ”  @      ì  @   f   À  »                ˇˇˇˇ   	      QC:\buildslave\unity\build\artifacts\generated\common\modules\VR\VRBindings.gen.cs                F%¬‚±„zf+Ò¶ËAã DC:\buildslave\unity\build\Runtime\VR\ScriptBindings\InputTracking.cs                Æê~}7.súc◊¸8Œà—â UC:\buildslave\unity\build\artifacts\generated\common\modules\VR\VRTestBindings.gen.cs                n
t‡4ãf“≈ÂÎõ [ BC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VRNodeState.cs                ˚Ã ¢r¡=ÕQ¸;w& DC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VR.deprecated.cs                ≥IìÓ	*»∆÷ü1 \[≠ MC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VRNodeState.deprecated.cs                ‡ë)ˇKïq≈˛ñeŒ” ^C:\buildslave\unity\build\Runtime\VR\HoloLens\ScriptBindings\HolographicSettings.deprecated.cs                í£Ï∂=k˝ñ¿K|[F WC:\buildslave\unity\build\Runtime\VR\HoloLens\ScriptBindings\WorldManager.deprecated.cs                N¢!8Ü∞È~2U4Ä7ä                  tmp   \2B ,,R_ä ëí    gc ¨ ≠Æ    kªZ<3 ƒ ≈∆    êZ3 		‰ ÂÊ  result   “3C *			ˇ â	ä	    ‹[2;3 		•	 ¶	ß	  result   á[Cc »	 “	”	  result   ñ"3C :				 ˙	˚	  result   ü"3C =			ñ
 †
°
  ˇˇˇˇ ∏;2=33 		º
 Ω
∆
  callback callbackParam ˇˇˇˇ#ÄˇˇˇˇÜé L"3"3"5‰;4;4;4;4ä=;3 		Î
 áõ    ;;; 1111· ‚„  boundaryType   Ñc A˝ çé    äc 		© ™´  boundaryType   ≥c <ƒ ‘’  ˇˇˇˇ π;2=4c 		 Ò˙    23 e		ü †°    *3 N		ª ºΩ    $*3 O		◊ ÿŸ    +*3 P		Û Ùı    2*3 K		è êë    9*3 O		´ ¨≠    @*3 P		« »…    )k „ ‰Â    -C ˝ ˛ˇ    5k ó òô    9C ± ≤≥    AÉ À ÃÕ    E£ Â ÊÁ    MC{ ˇ ÄÅ    VC{ õ úù    _C{ ∑ ∏π    hC{ ” ‘’    qCÉ Ô Ò    zCÉ ã åç    ÇRc 		ß ®©    áRc 		ƒ ≈∆    åRc 		· ‚„    ëRc 		˛ ˇÄ    ñZc 		õ úù    õZc 		∏ π∫  ˇˇˇˇ*ˇˇˇˇ*= †€CEcD 		’ ÷Á    .2 å çé    22 ¶ ß®    :2 ¿ ¡¬    B2 ⁄ €‹    F2 Ù ıˆ    N2 é èê    R2 ® ©™    Z2 ¬ √ƒ    b2 ‹ ›ﬁ    j2 ˆ ˜¯    n2 ê ëí    v2 ™ ´¨    z2 ƒ ≈∆    É2 ﬁ ﬂ‡    á2 ˘ ˙˚    ê2 î ïñ    ñ2 	Ø ∞±    õ2 	  ÀÃ    ¢2 Â ÊÁ    Æ2 Ä ÅÇ    ∂2 õ úù    ø2 ∂ ∑∏    «2 — “”    œ2 Ï ÌÓ    ’2 	á àâ    ⁄2 	¢ £§    ﬂ2 	Ω æø    Â2 	ÿ Ÿ⁄    ÓC2 	Û Ùı    Ù#2 	ê ëí    ˙#2 	≠ ÆØ    É2   ÀÃ    ç2 	Â ÊÁ    í2 	Ä ÅÇ    ó2 	õ úù    ú2 	∂ ∑∏    £2 — “”    ß2 Ï ÌÓ    2 á àâ    2 ° ¢£    2 ª ºΩ    2 ’ ÷◊    &2 Ô Ò    *2 â äã    22 £ §•    :2 Ω æø    B2 ◊ ÿŸ    J2 Ò ÚÛ    R2 ã åç    Z2 • ¶ß    aC2 	ø ¿¡    gC2 	€ ‹›    mC2 	˜ ¯˘    sC2 	ì îï    yC2 	Ø ∞±    C2 	À ÃÕ     		Á ËÈ    C ˇ ÄÅ    C ô öõ     		≥ ¥µ   "      :  /    Z  G    u  g    õ  ã  !  æ  ®  (  Ê  ‘  )    ¸  +  2  "  0  a  G  ;  ◊  ú  <  Û  ‰  =      >  :  ,  @  f  V  A  ï  {  H  ±  ¢  J  Õ  æ  L  È  ⁄  N    ˆ  P  !    R  =  .  T  Y  J  Y  s  f  Z  ç  Ä  [  ß  ö  \  ¡  ¥  ]  €  Œ  ^  ı  Ë  _      `  -    a  I  :  b  e  V  c  Å  r  d  ù  é  e  ∫  ™  f  ◊  «  g  Ù  ‰  h  	  	  i  .	  	  j  K	  ;	  k  Ç	  h	  l  ú	  è	  m  ∂	  ©	  n  –	  √	  o  Í	  ›	  p  
  ˜	  q  
  
  r  8
  +
  s  R
  E
  t  l
  _
  u  Ü
  y
  v  †
  ì
  w  ∫
  ≠
  x  ‘
  «
  y  Ô
  ·
  z  
  ¸
  {  %    |  @  2  }  [  M  ~  v  h    ë  É  Ä  ¨  û  Å  «  π  Ç  ‚  ‘  É  ˝  Ô  Ñ    
  Ö  3  %  Ü  N  @  á  i  [  à  Ü  v  â  £  ì  ä  ¿  ∞  ã  €  Õ  å  ˆ  Ë  ç      é  ,    è  G  9  ê  b  T  ë  }  o  í  ó  ä  ì  ±  §  î  À  æ  ï  Â  ÿ  ñ  ˇ  Ú  ó      ò  3  &  ô  M  @  ö  g  Z  õ  Å  t  ú  õ  é  ù  µ  ®  û  —  ¬  ü  Ì  ﬁ  †  	  ˙  °  %    ¢  A  2  £  ]  N  •  u  j  ¶  è  Ç  ®  ©  ú  ©  ¡  ∂     p      „      I     ¿     $     ä     ˘     y     Ú     ı     ¯     ˚     ˛                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      