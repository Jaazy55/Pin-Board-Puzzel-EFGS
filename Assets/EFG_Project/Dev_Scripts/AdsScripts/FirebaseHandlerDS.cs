////using Firebase.Analytics;
//using UnityEngine;
//public class FirebaseHandlerCG : MonoBehaviour
//{
//    public static FirebaseHandlerCG instance;
//    private bool NetworkService;
//    private void Awake()
//    {
//        instance = this;
//    }
//    void Start()
//    {
//        if (ConstantsCG.GetBoolpref(ConstantsCG.Lowenddevice))
//            return;

//        if (Application.internetReachability != NetworkReachability.NotReachable)
//        {
//            Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
//            {
//                var dependencyStatus = task.Result;
//                if (dependencyStatus == Firebase.DependencyStatus.Available)
//                {
//                    // Create and hold a reference to your FirebaseApp,
//                    // where app is a Firebase.FirebaseApp property of your application class.
//                    Firebase.FirebaseApp app = Firebase.FirebaseApp.DefaultInstance;

//                    // Set a flag here to indicate whether Firebase is ready to use by your app.
//                    FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
//                    ConstantsCG.FirebaseInitilized = true;
//                    Debug.Log(" resolve all Firebase dependencies");

//                }
//                else if (dependencyStatus == Firebase.DependencyStatus.UnavailableDisabled)
//                {
//                    ConstantsCG.FirebaseInitilized = false;
//                    Debug.Log("Firebase dependencies UnavailableDisabled");
//                }
//                else
//                {
//                    UnityEngine.Debug.LogError(System.String.Format(
//                      "Could not resolve all Firebase dependencies: {0}", dependencyStatus));
//                    Debug.Log("Firebase Unity SDK is not safe to use here");
//                    //  Firebase Unity SDK is not safe to use here.
//                }
//            });
//        }
//    }
//}
