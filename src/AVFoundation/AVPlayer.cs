//
// AVPlayer.cs: Complementing methods
//
// Author:
//   Miguel de Icaza (miguel@xamarin.com)
//
// Copyright 2012, Xamarin Inc
//
using System;
using MonoTouch.Foundation;
using MonoTouch.CoreMedia;

namespace MonoTouch.AVFoundation {
	public partial class AVPlayer {
		[Obsolete ("Use Seek(CMTime, AVCompletion) instead, the callback contains a `bool finished' parameter")]
		public void Seek (CMTime time, AVCompletionHandler completion)
		{
			Seek (time, (x) => { completion (); });
		}

		[Obsolete ("Use Seek(CMTime, CMTime, CMTIme, AVCompletion) instead, the callback contains a `bool finished' parameter")]
		public void Seek (CMTime time, CMTime toleranceBefore, CMTime toleranceAfter, AVCompletionHandler completion)
		{
			Seek (time, toleranceBefore, toleranceAfter, (x) => { completion (); });
		}
	}

	public partial class AVPlayerItem {
		[Obsolete ("Use Seek(CMTime, CMTime, CMTIme, AVCompletion) instead, the callback contains a `bool finished' parameter")]
		public void Seek (CMTime time, CMTime toleranceBefore, CMTime toleranceAfter, AVCompletionHandler completion)
		{
			Seek (time, toleranceBefore, toleranceAfter, (x) => { completion (); });
		}
	}
}