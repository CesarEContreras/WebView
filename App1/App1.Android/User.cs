using System;

namespace App1.Droid
{
	public class User: Java.Lang.Object, Java.Lang.IRunnable
	{
		public User ()
		{
		}

		void Java.Lang.IRunnable.Run ()
		{
			throw new NotImplementedException ();
		}

		public string GetUserDetails()
		{
			return "ccontreras@okkralabs.com";
		}
	}
}

