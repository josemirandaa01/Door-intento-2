using System;

namespace ClassLibrary1
{
	public class Door
	{

		bool open;
		bool locked;


		public static (bool,bool) OpenAndUnlockedDoor()
		{
			Door OpenAndUnlocked = new Door();
			OpenAndUnlocked.open = true;
			OpenAndUnlocked.locked = false;

			return (OpenAndUnlocked.open , OpenAndUnlocked.locked);
		}

		public static (bool, bool) OpenAndLockedDoor()
		{
			Door OpenAndLocked = new Door();
			OpenAndLocked.open = true;
			OpenAndLocked.locked = true;

			return (OpenAndLocked.open, OpenAndLocked.locked);
		}

		public static (bool, bool) ClosedAndLockedDoor()
		{
			Door ClosedAndLocked = new Door();
			ClosedAndLocked.open = false;
			ClosedAndLocked.locked = true;

			return (ClosedAndLocked.open, ClosedAndLocked.locked);
		}

		public static (bool, bool) ClosedAndUnlockedDoor()
		{
			Door ClosedAndUnlocked = new Door();
			ClosedAndUnlocked.open = false;
			ClosedAndUnlocked.locked = false;

			return (ClosedAndUnlocked.open, ClosedAndUnlocked.locked);
		}


	}

}
