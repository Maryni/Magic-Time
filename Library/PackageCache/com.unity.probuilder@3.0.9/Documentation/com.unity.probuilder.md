
<div class="current toggle" data-target=".lang-list">
<div class="lbl">Language: <span class="b">English</span>
</div>
<div class="arrow"></div>
</div>
<div class="lang-list" style="display:none;"><ul>
<li><a href="/Manual/class-AudioCompressor.html">English</a></li>
<li><a href="/ja/current/Manual/class-AudioCompressor.html">日本語</a></li>
<li><a href="/es/current/Manual/class-AudioCompressor.html">Español</a></li>
<li><a href="/kr/current/Manual/class-AudioCompressor.html">한국어</a></li>
<li><a href="/ru/current/Manual/class-AudioCompressor.html">Русский</a></li>
</ul></div>
</div>
</div></div>
</div>
<div id="master-wrapper" class="master-wrapper clear">
<div id="sidebar" class="sidebar"><div class="sidebar-wrap"><div class="content"><div class="sidebar-menu"><div class="toc"><h2>Unity Manual</h2></div></div></div></div></div>
<div id="content-wrap" class="content-wrap"><div class="content-block"><div class="content">
<div class="section">
<div class="breadcrumbs clear"><ul>
<li><a href="UnityManual.html">Unity User Manual (2018.3)</a></li>
<li><a href="Audio.html">Audio</a></li>
<li>Audio Reference</li>
<li><a href="class-AudioEffectMixer.html">Audio Effects</a></li>
<li>Audio Compressor Effect</li>
</ul></div>
<div class="mb20"><div class="nextprev clear">
<div class="icon tt left mr1" data-distance="-40|-30|top">
<span class="prev"><a href="class-AudioChorusEffect.html"></a></span><div class="tip">Audio Chorus Effect</div>
</div>
<div class="icon tt right" data-distance="-40|-30|top">
<span class="next"><a href="class-AudioReverbEffect.html"></a></span><div class="tip">Audio SFX Reverb Effect</div>
</div>
</div></div>
<div class="otherversionswrapper" onmouseover="setOtherVersionsDisplay(true)" onmouseout="setOtherVersionsDisplay(false)">
<a>Other Versions</a><div class="otherversionscontent" id="OtherVersionsContent" style="display: none;">Cannot access other versions offline!</div>
</div>
<div class="scrollToFeedback"><a id="scrollToFeedback">Leave feedback</a></div>
<h1>Audio Compressor Effect</h1>
<!--BeginSwitchLink--><!--EndSwitchLink-->
<div class="clear"></div>

<p>The <strong>Audio Compressor Effect</strong> reduces the volume of loud sounds or amplifies quiet sounds by narrowing or “compressing” an audio signal’s dynamic range.</p>

<h2>Properties</h2>

<figure>
<img src="../uploads/Main/AudioCompressorEffect.png" alt="">
</figure>

<table>
<colgroup>
<col style="text-align:left;">
<col style="text-align:left;">
</colgroup>

<thead>
<tr>
	<th style="text-align:left;"><strong><em>Property:</em></strong></th>
	<th style="text-align:left;"><strong><em>Function:</em></strong></th>
</tr>
</thead>

<tbody>
<tr>
	<td style="text-align:left;"><strong>Threshold</strong></td>
	<td style="text-align:left;">Threshold level in dB (range 0 to –60dB, default = 0dB).</td>
</tr>
<tr>
	<td style="text-align:left;"><strong>Attack</strong></td>
	<td style="text-align:left;">The rate the effect is applied in ms. (range 10.0 to 200.0 ms, default = 50.0 ms).</td>
</tr>
<tr>
	<td style="text-align:left;"><strong>Release</strong></td>
	<td style="text-align:left;">The rate the effect is released in ms. (range 20.0 to 1000.0 ms, default = 50.0 ms).</td>
</tr>
<tr>
	<td style="text-align:left;"><strong>Make up gain</strong></td>
	<td style="text-align:left;">Make up gain level in dB (range 0 to 30dB, default = 0dB).</td>
</tr>
</tbody>
</table>

<div class="feedbackbox" id="feedbackbox">
<div id="rating"><p>Did you find this page useful? Please give it a rating:<br><div id="ratecontent" class="c-rating"></div>
</p></div>
<div id="ratingThanks" style="display:none"><p>Thanks for rating this page!</p></div>
<div id="problem"><p><a name="problem">Report a problem on this page</a></p></div>
<div id="problemType" style="display:none"><p>What kind of problem would you like to report?<ul type="problems">
<li><a name="needcode" id="problemneedcode">This page needs code samples</a></li>
<li><a name="code" id="problemcode">Code samples do not work</a></li>
<li><a name="missing" id="problemmissing">Information is missing</a></li>
<li><a name="incorrect" id="problemincorrect">Information is incorrect</a></li>
<li><a name="unclear" id="problemunclear">Information is unclear or confusing</a></li>
<li><a name="language" id="problemlanguage">There is a spelling/grammar error on this page</a></li>
<li><a name="other" id="problemother">Something else</a></li>
</ul>
<p><known_issues><p>Is something described here not working as you expect it to? It might be a <b>Known Issue</b>. Please check with the Issue Tracker at <a href="https://issuetracker.unity3d.com">issuetracker.unity3d.com</a>.</p></known_issues></p>
</p></div>
<div id="problemThanks" style="display:none"><p>Thanks for letting us know! This page has been marked for review based on your feedback.<br><br>If you have time, you can provide more information to help us fix the problem faster.<br><br><a id="problemThanksMoreInfoButton">Provide more information</a><br>
</p></div>
<div id="problemMoreInfo" style="display:none">
<p id="problemNeedCodeForm" style="display:none">You've told us this page needs code samples. If you'd like to help us further, you could provide a code sample, or tell us about what kind of code sample you'd like to see:</p>
<p id="problemCodeForm" style="display:none">You've told us there are code samples on this page which don't work. If you know how to fix it, or have something better we could use instead, please let us know:</p>
<p id="problemMissingForm" style="display:none">You've told us there is information missing from this page. Please tell us more about what's missing:</p>
<p id="problemIncorrectForm" style="display:none">You've told us there is incorrect information on this page. If you know what we should change to make it correct, please tell us:</p>
<p id="problemUnclearForm" style="display:none">You've told us this page has unclear or confusing information. Please tell us more about what you found unclear or confusing, or let us know how we could make it clearer:</p>
<p id="problemLanguageForm" style="display:none">You've told us there is a spelling or grammar error on this page. Please tell us what's wrong:</p>
<p id="problemOtherForm" style="display:none">You've told us this page has a problem. Please tell us more about what's wrong:</p>
<form>
<textarea id="problemFormSuggestionField" cols="40" rows="5"></textarea><input type="hidden" id="problemFormDescription"><input type="submit" id="problemFormDescriptionSubmit" value="Submit">
</form>
</div>
<div id="problemMoreInfoThanks" style="display:none"><p>Thanks for helping to make the Unity documentation better!</p></div>
<script>InitialiseStarRating();</script>
</div>
<div class="nextprev clear">
<div class="icon tt left mr1" data-distance="-40|-30|top">
<span class="prev"><a href="class-AudioChorusEffect.html"></a></span><div class="tip">Audio Chorus Effect</div>
</div>
<div class="icon tt right" data-distance="-40|-30|top">
<span class="next"><a href="class-AudioReverbEffect.html"></a></span><div class="tip">Audio SFX Reverb Effect</div>
</div>
</div>
</div>
<div class="footer-wrapper"><div class="footer clear">
<div class="copy">Copyright © 2018 Unity Technologies. Publication: 2018.3-002N. Built: 2018-12-04.</div>
<div class="menu">
<a href="https://unity3d.com/learn">Tutorials</a><a href="https://answers.unity3d.com">Community Answers</