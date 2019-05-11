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
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ��#&�E2       CP�d�g�K���TU��  p   [     �  @      �  @   f   �  �                ����   	      QC:\buildslave\unity\build\artifacts\generated\common\modules\VR\VRBindings.gen.cs                F%���zf+��A� DC:\buildslave\unity\build\Runtime\VR\ScriptBindings\InputTracking.cs                ��~}7.s�c��8Έщ UC:\buildslave\unity\build\artifacts\generated\common\modules\VR\VRTestBindings.gen.cs                n
t�4�f�����[ BC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VRNodeState.cs                �� �r�=�Q�;w& DC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VR.deprecated.cs                �I��	*��֟1�\[� MC:\buildslave\unity\build\Runtime\VR\ScriptBindings\VRNodeState.deprecated.cs                ��)�K�q���e�� ^C:\buildslave\unity\build\Runtime\VR\HoloLens\ScriptBindings\HolographicSettings.deprecated.cs                ���=k���K|[F WC:\buildslave\unity\build\Runtime\VR\HoloLens\ScriptBindings\WorldManager.deprecated.cs                N�!8���~2U4�7�                  tmp   \2B ,,R_� ��    gc � ��    k�Z<3 � ��    �Z3 		� ��  result   �3C *			� �	�	    �[2;3 		�	 �	�	  result   �[Cc �	 �	�	  result   �"3C :			�	 �	�	  result   �"3C =			�
 �
�
  ���� �;2=33 		�
 �
�
  callback callbackParam ����#������� L"3"3"5�;4;4;4;4�=;3 		�
 ��    ;;; 1111� ��  boundaryType   �c A� ��    �c 		� ��  boundaryType   �c <� ��  ���� �;2=4c 		� ��    23 e		� ��    *3 N		� ��    $*3 O		� ��    +*3 P		� ��    2*3 K		� ��    9*3 O		� ��    @*3 P		� ��    )k � ��    -C � ��    5k � ��    9C � ��    A� � ��    E� � ��    MC{ � ��    VC{ � ��    _C{ � ��    hC{ � ��    qC� � ��    zC� � ��    �Rc 		� ��    �Rc 		� ��    �Rc 		� ��    �Rc 		� ��    �Zc 		� ��    �Zc 		� ��  ����*����*= ��CEcD 		� ��    .2 � ��    22 � ��    :2 � ��    B2 � ��    F2 � ��    N2 � ��    R2 � ��    Z2 � ��    b2 � ��    j2 � ��    n2 � ��    v2 � ��    z2 � ��    �2 � ��    �2 � ��    �2 � ��    �2 	� ��    �2 	� ��    �2 � ��    �2 � ��    �2 � ��    �2 � ��    �2 � ��    �2 � ��    �2 	� ��    �2 	� ��    �2 	� ��    �2 	� ��    �C2 	� ��    �#2 	� ��    �#2 	� ��    �2 � ��    �2 	� ��    �2 	� ��    �2 	� ��    �2 	� ��    �2 � ��    �2 � ��    2 � ��    2 � ��    2 � ��    2 � ��    &2 � ��    *2 � ��    22 � ��    :2 � ��    B2 � ��    J2 � ��    R2 � ��    Z2 � ��    aC2 	� ��    gC2 	� ��    mC2 	� ��    sC2 	� ��    yC2 	� ��    C2 	� ��     		� ��    C � ��    C � ��     		� ��   "      :  /    Z  G    u  g    �  �  !  �  �  (  �  �  )    �  +  2  "  0  a  G  ;  �  �  <  �  �  =      >  :  ,  @  f  V  A  �  {  H  �  �  J  �  �  L  �  �  N    �  P  !    R  =  .  T  Y  J  Y  s  f  Z  �  �  [  �  �  \  �  �  ]  �  �  ^  �  �  _      `  -    a  I  :  b  e  V  c  �  r  d  �  �  e  �  �  f  �  �  g  �  �  h  	  	  i  .	  	  j  K	  ;	  k  �	  h	  l  �	  �	  m  �	  �	  n  �	  �	  o  �	  �	  p  
  �	  q  
  
  r  8
  +
  s  R
  E
  t  l
  _
  u  �
  y
  v  �
  �
  w  �
  �
  x  �
  �
  y  �
  �
  z  
  �
  {  %    |  @  2  }  [  M  ~  v  h    �  �  �  �  �  �  �  �  �  �  �  �  �  �  �    
  �  3  %  �  N  @  �  i  [  �  �  v  �  �  �  �  �  �  �  �  �  �  �  �  �      �  ,    �  G  9  �  b  T  �  }  o  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �  �      �  3  &  �  M  @  �  g  Z  �  �  t  �  �  �  �  �  �  �  �  �  �  �  �  �  	  �  �  %    �  A  2  �  ]  N  �  u  j  �  �  �  �  �  �  �  �  �     p      �      I     �     $     �     �     y     �     �     �     �     �                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      