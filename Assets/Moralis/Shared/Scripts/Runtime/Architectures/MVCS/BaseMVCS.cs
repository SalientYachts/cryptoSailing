using MoralisUnity.Samples.Shared.Debugging;
using MoralisUnity.Samples.Shared.DesignPatterns.Creational.Singleton.CustomSingletonMonobehaviour;
using UnityEngine;

namespace MoralisUnity.Samples.Shared.Architectures.MVCS
{
	public class BaseMVCS<U> : CustomSingletonMonobehaviour<U> where U: MonoBehaviour
	{
		public static IDebug Debug = new UnityEngineDebug();
	}
	
    /// <summary>
    /// Replace with comments...
    /// </summary>
    public class BaseMVCS2<T> : BaseMVCS<T> where T: MonoBehaviour
    {
        //  Properties ------------------------------------

		
        //  Fields ----------------------------------------

		
        //  Initialization Methods-------------------------

		
        //  General Methods -------------------------------

		
        //  Event Handlers --------------------------------
    }
}