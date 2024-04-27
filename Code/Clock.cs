using Timer = System.Threading.Timer;

namespace GameCompute;

internal class Clock
{
	UInt32	mRateHZ		=1;		//clock speed
	bool	mbPaused	=true;	//single stepping?
	UInt64	mTotalTime	=0;		//probably a bad idea

	internal event EventHandler	?eTick;

	
	//called 
	public void Pump()
	{
	}


	internal void SingleStep()
	{
		eTick?.Invoke(null, null);
	}


	internal void SetSpeed(UInt32 speed)
	{
		mRateHZ	=speed;
	}


	internal void Start()
	{
		mMain.Change()
	}
}