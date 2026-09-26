; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [434 x i64] [
	i64 2646484529726201, ; 0: FFImageLoading.Forms.Platform => 0x966f6b24c42f9 => 17
	i64 24362543149721218, ; 1: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 109
	i64 120698629574877762, ; 2: Mono.Android => 0x1accec39cafe242 => 28
	i64 196720943101637631, ; 3: System.Linq.Expressions.dll => 0x2bae4a7cd73f3ff => 215
	i64 210515253464952879, ; 4: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 98
	i64 232391251801502327, ; 5: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 136
	i64 263803244706540312, ; 6: Rg.Plugins.Popup.dll => 0x3a937a743542b18 => 36
	i64 295915112840604065, ; 7: Xamarin.AndroidX.SlidingPaneLayout => 0x41b4d3a3088a9a1 => 137
	i64 316157742385208084, ; 8: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 103
	i64 435170709725415398, ; 9: Xamarin.GooglePlayServices.Location => 0x60a097471d687e6 => 179
	i64 484766683456698147, ; 10: GalaSoft.MvvmLight.Extras.dll => 0x6ba3cbaee617723 => 24
	i64 590536689428908136, ; 11: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x83201fd803ec868 => 64
	i64 634308326490598313, ; 12: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 121
	i64 670107554435801057, ; 13: SkiaSharp.Extended.Svg.dll => 0x94cb34537739fe1 => 38
	i64 687654259221141486, ; 14: Xamarin.GooglePlayServices.Base => 0x98b09e7c92917ee => 176
	i64 702024105029695270, ; 15: System.Drawing.Common => 0x9be17343c0e7726 => 2
	i64 720058930071658100, ; 16: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x9fe29c82844de74 => 114
	i64 799765834175365804, ; 17: System.ComponentModel.dll => 0xb1956c9f18442ac => 4
	i64 816102801403336439, ; 18: Xamarin.Android.Support.Collections => 0xb53612c89d8d6f7 => 67
	i64 846634227898301275, ; 19: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0xbbfd9583890bb5b => 61
	i64 870603111519317375, ; 20: SQLitePCLRaw.lib.e_sqlite3.android => 0xc1500ead2756d7f => 44
	i64 872800313462103108, ; 21: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 108
	i64 940822596282819491, ; 22: System.Transactions => 0xd0e792aa81923a3 => 193
	i64 996343623809489702, ; 23: Xamarin.Forms.Platform => 0xdd3b93f3b63db26 => 168
	i64 1000557547492888992, ; 24: Mono.Security.dll => 0xde2b1c9cba651a0 => 216
	i64 1024351625343947416, ; 25: CarouselView.FormsPlugin.Android.dll => 0xe373a6041b85298 => 10
	i64 1120440138749646132, ; 26: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 173
	i64 1187742558705229585, ; 27: Xam.Plugin.TabView => 0x107bb590703d1f11 => 57
	i64 1252918907738889256, ; 28: Matrimony.Android.dll => 0x1163431bbc259c28 => 0
	i64 1301485588176585670, ; 29: SQLitePCLRaw.core => 0x120fce3f338e43c6 => 43
	i64 1315114680217950157, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 93
	i64 1342439039765371018, ; 31: Xamarin.Android.Support.Fragment => 0x12a14d31b1d4d88a => 76
	i64 1400031058434376889, ; 32: Plugin.Permissions.dll => 0x136de8d4787ec4b9 => 35
	i64 1425944114962822056, ; 33: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 6
	i64 1465843056802068477, ; 34: Xamarin.Firebase.Components.dll => 0x1457b87e6928f7fd => 152
	i64 1476839205573959279, ; 35: System.Net.Primitives.dll => 0x147ec96ece9b1e6f => 207
	i64 1490981186906623721, ; 36: Xamarin.Android.Support.VersionedParcelable => 0x14b1077d6c5c0ee9 => 85
	i64 1518315023656898250, ; 37: SQLitePCLRaw.provider.e_sqlite3 => 0x151223783a354eca => 45
	i64 1576750169145655260, ; 38: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x15e1bdecc376bfdc => 148
	i64 1579468382457870329, ; 39: Xamarin.GooglePlayServices.Places.PlaceReport => 0x15eb66201e5cb7f9 => 181
	i64 1624659445732251991, ; 40: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 91
	i64 1628611045998245443, ; 41: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 123
	i64 1636321030536304333, ; 42: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 115
	i64 1683207345377280184, ; 43: Matrimony => 0x175bf429a08a80b8 => 27
	i64 1731380447121279447, ; 44: Newtonsoft.Json => 0x18071957e9b889d7 => 31
	i64 1743969030606105336, ; 45: System.Memory.dll => 0x1833d297e88f2af8 => 49
	i64 1795316252682057001, ; 46: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 92
	i64 1808110659757781871, ; 47: CarouselView.FormsPlugin.Abstractions.dll => 0x1917b310b575b36f => 9
	i64 1836611346387731153, ; 48: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 136
	i64 1837131419302612636, ; 49: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x197ecd4ad53dce9c => 171
	i64 1851023096238382887, ; 50: CarouselView.FormsPlugin.Android => 0x19b027b2ea551f27 => 10
	i64 1875917498431009007, ; 51: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 88
	i64 1930726298510463061, ; 52: CommunityToolkit.Mvvm.dll => 0x1acb5156cd389055 => 14
	i64 1938067011858688285, ; 53: Xamarin.Android.Support.v4.dll => 0x1ae565add0bd691d => 84
	i64 1981742497975770890, ; 54: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 122
	i64 1984538867944326539, ; 55: FFImageLoading.Platform.dll => 0x1b8a7f95fac7058b => 18
	i64 2064708342624596306, ; 56: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x1ca7514c5eecb152 => 188
	i64 2133195048986300728, ; 57: Newtonsoft.Json.dll => 0x1d9aa1984b735138 => 31
	i64 2136356949452311481, ; 58: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 127
	i64 2148470725164780602, ; 59: FFImageLoading.Svg.Forms => 0x1dd0e6bdcfc5cc3a => 19
	i64 2165725771938924357, ; 60: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 96
	i64 2262844636196693701, ; 61: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 108
	i64 2284400282711631002, ; 62: System.Web.Services => 0x1fb3d1f42fd4249a => 198
	i64 2287887973817120656, ; 63: System.ComponentModel.DataAnnotations.dll => 0x1fc035fd8d41f790 => 201
	i64 2304837677853103545, ; 64: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 135
	i64 2329709569556905518, ; 65: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 118
	i64 2337758774805907496, ; 66: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 53
	i64 2427608535807450384, ; 67: Com.Android.DeskClock => 0x21b09919ee825d10 => 11
	i64 2470498323731680442, ; 68: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 102
	i64 2479423007379663237, ; 69: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 142
	i64 2489738558632930771, ; 70: Acr.UserDialogs.dll => 0x228d540722e8add3 => 7
	i64 2497223385847772520, ; 71: System.Runtime => 0x22a7eb7046413568 => 54
	i64 2547086958574651984, ; 72: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 87
	i64 2592350477072141967, ; 73: System.Xml.dll => 0x23f9e10627330e8f => 55
	i64 2624866290265602282, ; 74: mscorlib.dll => 0x246d65fbde2db8ea => 30
	i64 2625416601812051405, ; 75: GalaSoft.MvvmLight.dll => 0x246f5a7d426ba5cd => 23
	i64 2642180066339582676, ; 76: CarouselView.FormsPlugin.Abstractions => 0x24aae8c57ec9f2d4 => 9
	i64 2689097842293046233, ; 77: Matrimony.dll => 0x2551983d78257bd9 => 27
	i64 2694427813909235223, ; 78: Xamarin.AndroidX.Preference.dll => 0x256487d230fe0617 => 131
	i64 2783046991838674048, ; 79: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 53
	i64 2787234703088983483, ; 80: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 138
	i64 2863324215353042462, ; 81: FFImageLoading.Forms => 0x27bc92340ce4661e => 16
	i64 2949706848458024531, ; 82: Xamarin.Android.Support.SlidingPaneLayout => 0x28ef76c01de0a653 => 82
	i64 2960931600190307745, ; 83: Xamarin.Forms.Core => 0x2917579a49927da1 => 162
	i64 2977248461349026546, ; 84: Xamarin.Android.Support.DrawerLayout => 0x29514fb392c97af2 => 75
	i64 3017704767998173186, ; 85: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 173
	i64 3022227708164871115, ; 86: Xamarin.Android.Support.Media.Compat.dll => 0x29f11c168f8293cb => 80
	i64 3143515969535650208, ; 87: Xamarin.Firebase.Encoders => 0x2ba0031e85f0a9a0 => 154
	i64 3289520064315143713, ; 88: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 117
	i64 3303437397778967116, ; 89: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 89
	i64 3311221304742556517, ; 90: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 52
	i64 3344514922410554693, ; 91: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 191
	i64 3364695309916733813, ; 92: Xamarin.Firebase.Common => 0x2eb1cc8eb5028175 => 151
	i64 3411255996856937470, ; 93: Xamarin.GooglePlayServices.Basement => 0x2f5737416a942bfe => 177
	i64 3493805808809882663, ; 94: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 140
	i64 3522470458906976663, ; 95: Xamarin.AndroidX.SwipeRefreshLayout => 0x30e2543832f52197 => 139
	i64 3531994851595924923, ; 96: System.Numerics => 0x31042a9aade235bb => 51
	i64 3571415421602489686, ; 97: System.Runtime.dll => 0x319037675df7e556 => 54
	i64 3596565917252612164, ; 98: Xamarin.Forms.OpenWhatsApp => 0x31e991a5751e7044 => 165
	i64 3716579019761409177, ; 99: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 100: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 134
	i64 3772598417116884899, ; 101: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 109
	i64 3788644642786275579, ; 102: PanCardView => 0x3493f83ac17670fb => 32
	i64 3966267475168208030, ; 103: System.Memory => 0x370b03412596249e => 49
	i64 4154383907710350974, ; 104: System.ComponentModel => 0x39a7562737acb67e => 4
	i64 4187479170553454871, ; 105: System.Linq.Expressions => 0x3a1cea1e912fa117 => 215
	i64 4201423742386704971, ; 106: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 103
	i64 4239882675311405204, ; 107: Xamarin.Firebase.Encoders.JSON => 0x3ad716d44f44e894 => 155
	i64 4247996603072512073, ; 108: Xamarin.GooglePlayServices.Tasks => 0x3af3ea6755340049 => 183
	i64 4252163538099460320, ; 109: Xamarin.Android.Support.ViewPager.dll => 0x3b02b8357f4958e0 => 86
	i64 4335356748765836238, ; 110: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3c2a47fe48c7b3ce => 171
	i64 4337444564132831293, ; 111: SQLitePCLRaw.batteries_v2.dll => 0x3c31b2d9ae16203d => 42
	i64 4349341163892612332, ; 112: Xamarin.Android.Support.DocumentFile => 0x3c5bf6bea8cd9cec => 74
	i64 4416987920449902723, ; 113: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0x3d4c4b1c879b9883 => 66
	i64 4525561845656915374, ; 114: System.ServiceModel.Internals => 0x3ece06856b710dae => 199
	i64 4636684751163556186, ; 115: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 144
	i64 4702770163853758138, ; 116: Xamarin.Firebase.Components => 0x4143988c34cf0eba => 152
	i64 4743821336939966868, ; 117: System.ComponentModel.Annotations => 0x41d5705f4239b194 => 200
	i64 4759461199762736555, ; 118: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 120
	i64 4782108999019072045, ; 119: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0x425d76cc43bb0a2d => 95
	i64 4794310189461587505, ; 120: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 87
	i64 4795410492532947900, ; 121: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0x428cb86f8f9b7bbc => 139
	i64 4841234827713643511, ; 122: Xamarin.Android.Support.CoordinaterLayout => 0x432f856d041f03f7 => 69
	i64 4914391832395879945, ; 123: FFImageLoading.Transformations => 0x44336d5581099609 => 21
	i64 4963205065368577818, ; 124: Xamarin.Android.Support.LocalBroadcastManager.dll => 0x44e0d8b5f4b6a71a => 79
	i64 5081566143765835342, ; 125: System.Resources.ResourceManager.dll => 0x4685597c05d06e4e => 3
	i64 5099468265966638712, ; 126: System.Resources.ResourceManager => 0x46c4f35ea8519678 => 3
	i64 5142919913060024034, ; 127: Xamarin.Forms.Platform.Android.dll => 0x475f52699e39bee2 => 167
	i64 5178572682164047940, ; 128: Xamarin.Android.Support.Print.dll => 0x47ddfc6acbee1044 => 81
	i64 5202753749449073649, ; 129: Plugin.Media => 0x4833e4f841be63f1 => 34
	i64 5203618020066742981, ; 130: Xamarin.Essentials => 0x4836f704f0e652c5 => 149
	i64 5205316157927637098, ; 131: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 125
	i64 5256995213548036366, ; 132: Xamarin.Forms.Maps.Android.dll => 0x48f4994b4175a10e => 163
	i64 5288341611614403055, ; 133: Xamarin.Android.Support.Interpolator.dll => 0x4963f6ad4b3179ef => 77
	i64 5348796042099802469, ; 134: Xamarin.AndroidX.Media => 0x4a3abda9415fc165 => 126
	i64 5375264076663995773, ; 135: Xamarin.Forms.PancakeView => 0x4a98c632c779bd7d => 166
	i64 5376510917114486089, ; 136: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 142
	i64 5408338804355907810, ; 137: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 141
	i64 5446034149219586269, ; 138: System.Diagnostics.Debug => 0x4b94333452e150dd => 206
	i64 5451019430259338467, ; 139: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 101
	i64 5507995362134886206, ; 140: System.Core.dll => 0x4c705499688c873e => 47
	i64 5569727921930649143, ; 141: Matrimony.Android => 0x4d4ba6090a403e37 => 0
	i64 5574231584441077149, ; 142: Xamarin.AndroidX.Annotation.Jvm => 0x4d5ba617ae5f8d9d => 90
	i64 5655995608527325224, ; 143: Com.ViewPagerIndicator.dll => 0x4e7e220a0970c828 => 12
	i64 5692067934154308417, ; 144: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 146
	i64 5757522595884336624, ; 145: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 99
	i64 5767696078500135884, ; 146: Xamarin.Android.Support.Annotations.dll => 0x500af9065b6a03cc => 65
	i64 5814345312393086621, ; 147: Xamarin.AndroidX.Preference => 0x50b0b44182a5c69d => 131
	i64 5838482455892408505, ; 148: GalaSoft.MvvmLight.Platform => 0x510674dc2ad138b9 => 25
	i64 5896680224035167651, ; 149: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x51d5376bfbafdda3 => 119
	i64 6044705416426755068, ; 150: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0x53e31b8ccdff13fc => 83
	i64 6085203216496545422, ; 151: Xamarin.Forms.Platform.dll => 0x5472fc15a9574e8e => 168
	i64 6086316965293125504, ; 152: FormsViewGroup.dll => 0x5476f10882baef80 => 22
	i64 6092862891035488599, ; 153: Xamarin.Firebase.Measurement.Connector.dll => 0x548e32849d547157 => 160
	i64 6183170893902868313, ; 154: SQLitePCLRaw.batteries_v2 => 0x55cf092b0c9d6f59 => 42
	i64 6311200438583329442, ; 155: Xamarin.Android.Support.LocalBroadcastManager => 0x5795e35c580c82a2 => 79
	i64 6319713645133255417, ; 156: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 121
	i64 6401687960814735282, ; 157: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 118
	i64 6504860066809920875, ; 158: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 96
	i64 6548213210057960872, ; 159: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 106
	i64 6554405243736097249, ; 160: Xamarin.GooglePlayServices.Stats => 0x5af5ecd7aad901e1 => 182
	i64 6557084851308642443, ; 161: Xamarin.AndroidX.Window.dll => 0x5aff71ee6c58c08b => 147
	i64 6588599331800941662, ; 162: Xamarin.Android.Support.v4 => 0x5b6f682f335f045e => 84
	i64 6589202984700901502, ; 163: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 174
	i64 6591024623626361694, ; 164: System.Web.Services.dll => 0x5b7805f9751a1b5e => 198
	i64 6659513131007730089, ; 165: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0x5c6b57e8b6c3e1a9 => 114
	i64 6671798237668743565, ; 166: SkiaSharp => 0x5c96fd260152998d => 37
	i64 6876862101832370452, ; 167: System.Xml.Linq => 0x5f6f85a57d108914 => 56
	i64 6878582369430612696, ; 168: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x5f75a238802d2ad8 => 172
	i64 6894844156784520562, ; 169: System.Numerics.Vectors => 0x5faf683aead1ad72 => 52
	i64 6975328107116786489, ; 170: Xamarin.Firebase.Annotations => 0x60cd57f4e07e7339 => 150
	i64 7026573318513401069, ; 171: Xamarin.Firebase.Encoders.Proto.dll => 0x618367346e3a9ced => 156
	i64 7036436454368433159, ; 172: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x61a671acb33d5407 => 116
	i64 7103753931438454322, ; 173: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 113
	i64 7141281584637745974, ; 174: Xamarin.GooglePlayServices.Maps.dll => 0x631aedc3dd5f1b36 => 180
	i64 7194160955514091247, ; 175: Xamarin.Android.Support.CursorAdapter.dll => 0x63d6cb45d266f6ef => 72
	i64 7270811800166795866, ; 176: System.Linq => 0x64e71ccf51a90a5a => 212
	i64 7338192458477945005, ; 177: System.Reflection => 0x65d67f295d0740ad => 203
	i64 7345470581440696094, ; 178: Xamarin.GooglePlayServices.Places.PlaceReport.dll => 0x65f05a936adacf1e => 181
	i64 7385250113861300937, ; 179: Xamarin.Firebase.Iid.Interop.dll => 0x667dadd98e1db2c9 => 157
	i64 7476537270401454554, ; 180: Xamarin.Firebase.Encoders.JSON.dll => 0x67c1ff08f83f51da => 155
	i64 7488575175965059935, ; 181: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 56
	i64 7489048572193775167, ; 182: System.ObjectModel => 0x67ee71ff6b419e3f => 213
	i64 7635363394907363464, ; 183: Xamarin.Forms.Core.dll => 0x69f6428dc4795888 => 162
	i64 7637365915383206639, ; 184: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 149
	i64 7654504624184590948, ; 185: System.Net.Http => 0x6a3a4366801b8264 => 50
	i64 7660336384445167946, ; 186: GalaSoft.MvvmLight.Extras => 0x6a4efb5afedab94a => 24
	i64 7735352534559001595, ; 187: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 187
	i64 7820441508502274321, ; 188: System.Data => 0x6c87ca1e14ff8111 => 192
	i64 7821246742157274664, ; 189: Xamarin.Android.Support.AsyncLayoutInflater => 0x6c8aa67926f72e28 => 66
	i64 7836164640616011524, ; 190: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 91
	i64 7875371864198757046, ; 191: AndHUD.dll => 0x6d4af0fc27ac3ab6 => 8
	i64 7904570928025870493, ; 192: Xamarin.Firebase.Installations => 0x6db2ad60fadca09d => 158
	i64 7927939710195668715, ; 193: SkiaSharp.Views.Android.dll => 0x6e05b32992ed16eb => 39
	i64 7940488133782528123, ; 194: Xamarin.GooglePlayServices.CloudMessaging => 0x6e3247e31d4fe07b => 178
	i64 7969431548154767168, ; 195: Xamarin.Firebase.Installations.dll => 0x6e991bc4e98e6740 => 158
	i64 8044118961405839122, ; 196: System.ComponentModel.Composition => 0x6fa2739369944712 => 197
	i64 8064050204834738623, ; 197: System.Collections.dll => 0x6fe942efa61731bf => 202
	i64 8083354569033831015, ; 198: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 117
	i64 8101777744205214367, ; 199: Xamarin.Android.Support.Annotations => 0x706f4beeec84729f => 65
	i64 8103644804370223335, ; 200: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 194
	i64 8113615946733131500, ; 201: System.Reflection.Extensions => 0x70995ab73cf916ec => 5
	i64 8167236081217502503, ; 202: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 26
	i64 8185542183669246576, ; 203: System.Collections => 0x7198e33f4794aa70 => 202
	i64 8187102936927221770, ; 204: SkiaSharp.Views.Forms => 0x719e6ebe771ab80a => 40
	i64 8187640529827139739, ; 205: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 190
	i64 8196541262927413903, ; 206: Xamarin.Android.Support.Interpolator => 0x71bff6d9fb9ec28f => 77
	i64 8290740647658429042, ; 207: System.Runtime.Extensions => 0x730ea0b15c929a72 => 209
	i64 8318905602908530212, ; 208: System.ComponentModel.DataAnnotations => 0x7372b092055ea624 => 201
	i64 8385935383968044654, ; 209: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0x7460d3cd16cb566e => 63
	i64 8398329775253868912, ; 210: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 100
	i64 8400357532724379117, ; 211: Xamarin.AndroidX.Navigation.UI.dll => 0x749410ab44503ded => 130
	i64 8426919725312979251, ; 212: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 120
	i64 8465511506719290632, ; 213: Xamarin.Firebase.Messaging.dll => 0x757b89dcf7fc3508 => 161
	i64 8598790081731763592, ; 214: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 111
	i64 8601935802264776013, ; 215: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 141
	i64 8626175481042262068, ; 216: Java.Interop => 0x77b654e585b55834 => 26
	i64 8639588376636138208, ; 217: Xamarin.AndroidX.Navigation.Runtime => 0x77e5fbdaa2fda2e0 => 129
	i64 8684531736582871431, ; 218: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 196
	i64 8808820144457481518, ; 219: Xamarin.Android.Support.Loader.dll => 0x7a3f374010b17d2e => 78
	i64 8853378295825400934, ; 220: Xamarin.Kotlin.StdLib.Common.dll => 0x7add84a720d38466 => 186
	i64 8917102979740339192, ; 221: Xamarin.Android.Support.DocumentFile.dll => 0x7bbfe9ea4d000bf8 => 74
	i64 8951477988056063522, ; 222: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 133
	i64 9114191852432800567, ; 223: FFImageLoading.dll => 0x7e7c1d3363043b37 => 15
	i64 9238306115887712111, ; 224: FFImageLoading.Forms.dll => 0x80350e773bce476f => 16
	i64 9312692141327339315, ; 225: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 146
	i64 9324707631942237306, ; 226: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 92
	i64 9584643793929893533, ; 227: System.IO.dll => 0x85037ebfbbd7f69d => 205
	i64 9659729154652888475, ; 228: System.Text.RegularExpressions => 0x860e407c9991dd9b => 211
	i64 9662334977499516867, ; 229: System.Numerics.dll => 0x8617827802b0cfc3 => 51
	i64 9678050649315576968, ; 230: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 102
	i64 9695067051349111183, ; 231: PanCardView.Droid.dll => 0x868bcc1dd541f18f => 33
	i64 9711637524876806384, ; 232: Xamarin.AndroidX.Media.dll => 0x86c6aadfd9a2c8f0 => 126
	i64 9720113355794297314, ; 233: CommonServiceLocator => 0x86e4c79904a631e2 => 13
	i64 9735414641753518179, ; 234: Xamarin.Firebase.Encoders.Proto => 0x871b240946daf063 => 156
	i64 9774216967140627647, ; 235: Xamarin.Firebase.Datatransport.dll => 0x87a4fe8bac0354bf => 153
	i64 9780093022148426479, ; 236: Xamarin.AndroidX.Window.Extensions.Core.Core.dll => 0x87b9dec9576efaef => 148
	i64 9780723996889434231, ; 237: AndHUD => 0x87bc1ca798bbc877 => 8
	i64 9796610708422913120, ; 238: Xamarin.Firebase.Iid.Interop => 0x87f48d88de55ec60 => 157
	i64 9808709177481450983, ; 239: Mono.Android.dll => 0x881f890734e555e7 => 28
	i64 9825649861376906464, ; 240: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 99
	i64 9834056768316610435, ; 241: System.Transactions.dll => 0x8879968718899783 => 193
	i64 9866412715007501892, ; 242: Xamarin.Android.Arch.Lifecycle.Common.dll => 0x88ec8a16fd6b6644 => 60
	i64 9875200773399460291, ; 243: Xamarin.GooglePlayServices.Base.dll => 0x890bc2c8482339c3 => 176
	i64 9907349773706910547, ; 244: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 111
	i64 9998632235833408227, ; 245: Mono.Security => 0x8ac2470b209ebae3 => 216
	i64 10037412179342310022, ; 246: CommonServiceLocator.dll => 0x8b4c0d3255e0ba86 => 13
	i64 10038780035334861115, ; 247: System.Net.Http.dll => 0x8b50e941206af13b => 50
	i64 10226222362177979215, ; 248: Xamarin.Kotlin.StdLib.Jdk7 => 0x8dead70ebbc6434f => 188
	i64 10229024438826829339, ; 249: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 106
	i64 10303855825347935641, ; 250: Xamarin.Android.Support.Loader => 0x8efea647eeb3fd99 => 78
	i64 10321854143672141184, ; 251: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 185
	i64 10352330178246763130, ; 252: Xamarin.Firebase.Measurement.Connector => 0x8faadd72b7f4627a => 160
	i64 10360651442923773544, ; 253: System.Text.Encoding => 0x8fc86d98211c1e68 => 210
	i64 10363495123250631811, ; 254: Xamarin.Android.Support.Collections.dll => 0x8fd287e80cd8d483 => 67
	i64 10376576884623852283, ; 255: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 140
	i64 10406448008575299332, ; 256: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 191
	i64 10430153318873392755, ; 257: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 104
	i64 10549908655231907690, ; 258: Xamarin.Forms.OpenWhatsApp.dll => 0x9268ce06afeab76a => 165
	i64 10566960649245365243, ; 259: System.Globalization.dll => 0x92a562b96dcd13fb => 214
	i64 10635644668885628703, ; 260: Xamarin.Android.Support.DrawerLayout.dll => 0x93996679ee34771f => 75
	i64 10714184849103829812, ; 261: System.Runtime.Extensions.dll => 0x94b06e5aa4b4bb34 => 209
	i64 10775409704848971057, ; 262: Xamarin.Forms.Maps => 0x9589f20936d1d531 => 164
	i64 10785150219063592792, ; 263: System.Net.Primitives => 0x95ac8cfb68830758 => 207
	i64 10847732767863316357, ; 264: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 93
	i64 10850923258212604222, ; 265: Xamarin.Android.Arch.Lifecycle.Runtime => 0x9696393672c9593e => 63
	i64 11019817191295005410, ; 266: Xamarin.AndroidX.Annotation.Jvm.dll => 0x98ee415998e1b2e2 => 90
	i64 11023048688141570732, ; 267: System.Core => 0x98f9bc61168392ac => 47
	i64 11037814507248023548, ; 268: System.Xml => 0x992e31d0412bf7fc => 55
	i64 11071824625609515081, ; 269: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 174
	i64 11162124722117608902, ; 270: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 145
	i64 11171845786728836392, ; 271: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x9b0a5e8d536aad28 => 178
	i64 11201462017695523848, ; 272: FFImageLoading.Transformations.dll => 0x9b73965b71c5a408 => 21
	i64 11336891506707244397, ; 273: Xamarin.Firebase.Datatransport => 0x9d54bac28a6da56d => 153
	i64 11340910727871153756, ; 274: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 105
	i64 11376351552967644903, ; 275: Xamarin.Firebase.Annotations.dll => 0x9de0eb76829996e7 => 150
	i64 11376461258732682436, ; 276: Xamarin.Android.Support.Compat => 0x9de14f3d5fc13cc4 => 68
	i64 11392833485892708388, ; 277: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 132
	i64 11444370155346000636, ; 278: Xamarin.Forms.Maps.Android => 0x9ed292057b7afafc => 163
	i64 11446671985764974897, ; 279: Mono.Android.Export => 0x9edabf8623efc131 => 29
	i64 11529969570048099689, ; 280: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 145
	i64 11578238080964724296, ; 281: Xamarin.AndroidX.Legacy.Support.V4 => 0xa0ae2a30c4cd8648 => 116
	i64 11580057168383206117, ; 282: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 88
	i64 11591352189662810718, ; 283: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 138
	i64 11597940890313164233, ; 284: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 285: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 113
	i64 11739066727115742305, ; 286: SQLite-net.dll => 0xa2e98afdf8575c61 => 41
	i64 11743665907891708234, ; 287: System.Threading.Tasks => 0xa2f9e1ec30c0214a => 204
	i64 11806260347154423189, ; 288: SQLite-net => 0xa3d8433bc5eb5d95 => 41
	i64 11834399401546345650, ; 289: Xamarin.Android.Support.SlidingPaneLayout.dll => 0xa43c3b8deb43ecb2 => 82
	i64 11865714326292153359, ; 290: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa4ab7c5000e8440f => 62
	i64 12102847907131387746, ; 291: System.Buffers => 0xa7f5f40c43256f62 => 46
	i64 12123043025855404482, ; 292: System.Reflection.Extensions.dll => 0xa83db366c0e359c2 => 5
	i64 12137774235383566651, ; 293: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 143
	i64 12279246230491828964, ; 294: SQLitePCLRaw.provider.e_sqlite3.dll => 0xaa68a5636e0512e4 => 45
	i64 12346958216201575315, ; 295: Xamarin.JavaX.Inject.dll => 0xab593514a5491b93 => 184
	i64 12388767885335911387, ; 296: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0xabedbec0d236dbdb => 62
	i64 12414299427252656003, ; 297: Xamarin.Android.Support.Compat.dll => 0xac48738e28bad783 => 68
	i64 12451044538927396471, ; 298: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 112
	i64 12466513435562512481, ; 299: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 124
	i64 12487638416075308985, ; 300: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 107
	i64 12538491095302438457, ; 301: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 97
	i64 12550732019250633519, ; 302: System.IO.Compression => 0xae2d28465e8e1b2f => 195
	i64 12700543734426720211, ; 303: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 98
	i64 12704600701734554468, ; 304: Xam.Plugin.TabView.dll => 0xb04fcf06c0110b64 => 57
	i64 12708238894395270091, ; 305: System.IO => 0xb05cbbf17d3ba3cb => 205
	i64 12753841065332862057, ; 306: Xamarin.AndroidX.Window => 0xb0febee04cf46c69 => 147
	i64 12828192437253469131, ; 307: Xamarin.Kotlin.StdLib.Jdk8.dll => 0xb206e50e14d873cb => 189
	i64 12854524964145442905, ; 308: Xamarin.Firebase.Encoders.dll => 0xb26472594447b059 => 154
	i64 12952608645614506925, ; 309: Xamarin.Android.Support.Core.Utils => 0xb3c0e8eff48193ad => 71
	i64 12963446364377008305, ; 310: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 2
	i64 13129914918964716986, ; 311: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 110
	i64 13185305731832515997, ; 312: GalaSoft.MvvmLight.Platform.dll => 0xb6fb9db450cc8d9d => 25
	i64 13358059602087096138, ; 313: Xamarin.Android.Support.Fragment.dll => 0xb9615c6f1ee5af4a => 76
	i64 13370592475155966277, ; 314: System.Runtime.Serialization => 0xb98de304062ea945 => 6
	i64 13401370062847626945, ; 315: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 143
	i64 13404347523447273790, ; 316: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 100
	i64 13454009404024712428, ; 317: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 175
	i64 13465488254036897740, ; 318: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 187
	i64 13491513212026656886, ; 319: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 94
	i64 13492263892638604996, ; 320: SkiaSharp.Views.Forms.dll => 0xbb3e2686788d9ec4 => 40
	i64 13572454107664307259, ; 321: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 134
	i64 13643785327914841093, ; 322: Plugin.Media.dll => 0xbd587677c60cf405 => 34
	i64 13647894001087880694, ; 323: System.Data.dll => 0xbd670f48cb071df6 => 192
	i64 13828521679616088467, ; 324: Xamarin.Kotlin.StdLib.Common => 0xbfe8c733724e1993 => 186
	i64 13829530607229561650, ; 325: Xamarin.Firebase.Installations.InterOp => 0xbfec5cd0b64f6b32 => 159
	i64 13959074834287824816, ; 326: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 112
	i64 13967638549803255703, ; 327: Xamarin.Forms.Platform.Android => 0xc1d70541e0134797 => 167
	i64 14124974489674258913, ; 328: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 97
	i64 14125464355221830302, ; 329: System.Threading.dll => 0xc407bafdbc707a9e => 208
	i64 14161076099266624234, ; 330: Acr.UserDialogs => 0xc4863faf060fbaea => 7
	i64 14164783236351491542, ; 331: FFImageLoading.Svg.Platform.dll => 0xc4936b4e23237dd6 => 20
	i64 14172845254133543601, ; 332: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 127
	i64 14240145736568846764, ; 333: Com.ViewPagerIndicator => 0xc59f291991fab9ac => 12
	i64 14252460695396124839, ; 334: FFImageLoading.Svg.Forms.dll => 0xc5cae97d5c4d88a7 => 19
	i64 14261073672896646636, ; 335: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 132
	i64 14327695147300244862, ; 336: System.Reflection.dll => 0xc6d632d338eb4d7e => 203
	i64 14343779804637125676, ; 337: PanCardView.Droid => 0xc70f57bc57d15c2c => 33
	i64 14400856865250966808, ; 338: Xamarin.Android.Support.Core.UI => 0xc7da1f051a877d18 => 70
	i64 14454106681488828596, ; 339: PanCardView.dll => 0xc8974d7217bde8b4 => 32
	i64 14486659737292545672, ; 340: Xamarin.AndroidX.Lifecycle.LiveData => 0xc90af44707469e88 => 119
	i64 14495724990987328804, ; 341: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 135
	i64 14524915121004231475, ; 342: Xamarin.JavaX.Inject => 0xc992dd58a4283b33 => 184
	i64 14644440854989303794, ; 343: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 125
	i64 14661790646341542033, ; 344: Xamarin.Android.Support.SwipeRefreshLayout => 0xcb7924e94e552091 => 83
	i64 14678510994762383812, ; 345: Xamarin.GooglePlayServices.Location.dll => 0xcbb48bfaca7a41c4 => 179
	i64 14789919016435397935, ; 346: Xamarin.Firebase.Common.dll => 0xcd4058fc2f6d352f => 151
	i64 14792063746108907174, ; 347: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 175
	i64 14809388726477333247, ; 348: Xamarin.GooglePlayServices.Stats.dll => 0xcd8584954e5b22ff => 182
	i64 14852515768018889994, ; 349: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 105
	i64 14987728460634540364, ; 350: System.IO.Compression.dll => 0xcfff1ba06622494c => 195
	i64 14988210264188246988, ; 351: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 107
	i64 15076659072870671916, ; 352: System.ObjectModel.dll => 0xd13b0d8c1620662c => 213
	i64 15133485256822086103, ; 353: System.Linq.dll => 0xd204f0a9127dd9d7 => 212
	i64 15150743910298169673, ; 354: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 133
	i64 15188640517174936311, ; 355: Xamarin.Android.Arch.Core.Common => 0xd2c8e413d75142f7 => 58
	i64 15246441518555807158, ; 356: Xamarin.Android.Arch.Core.Common.dll => 0xd3963dc832493db6 => 58
	i64 15279429628684179188, ; 357: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 190
	i64 15326820765897713587, ; 358: Xamarin.Android.Arch.Core.Runtime.dll => 0xd4b3ce481769e7b3 => 59
	i64 15370334346939861994, ; 359: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 104
	i64 15398511348637731642, ; 360: FFImageLoading.Forms.Platform.dll => 0xd5b2807c9d5f8b3a => 17
	i64 15404322903526314552, ; 361: FFImageLoading.Svg.Platform => 0xd5c72610ae199238 => 20
	i64 15406949360826139137, ; 362: Com.Android.DeskClock.dll => 0xd5d07ad06c794201 => 11
	i64 15457813392950723921, ; 363: Xamarin.Android.Support.Media.Compat => 0xd6852f61c31a8551 => 80
	i64 15526743539506359484, ; 364: System.Text.Encoding.dll => 0xd77a12fc26de2cbc => 210
	i64 15568534730848034786, ; 365: Xamarin.Android.Support.VersionedParcelable.dll => 0xd80e8bda21875fe2 => 85
	i64 15582737692548360875, ; 366: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 123
	i64 15609085926864131306, ; 367: System.dll => 0xd89e9cf3334914ea => 48
	i64 15777549416145007739, ; 368: Xamarin.AndroidX.SlidingPaneLayout.dll => 0xdaf51d99d77eb47b => 137
	i64 15810740023422282496, ; 369: Xamarin.Forms.Xaml => 0xdb6b08484c22eb00 => 169
	i64 15817206913877585035, ; 370: System.Threading.Tasks.dll => 0xdb8201e29086ac8b => 204
	i64 15930129725311349754, ; 371: Xamarin.GooglePlayServices.Tasks.dll => 0xdd1330956f12f3fa => 183
	i64 16154507427712707110, ; 372: System => 0xe03056ea4e39aa26 => 48
	i64 16242842420508142678, ; 373: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe16a2b1f8908ac56 => 69
	i64 16324796876805858114, ; 374: SkiaSharp.dll => 0xe28d5444586b6342 => 37
	i64 16423015068819898779, ; 375: Xamarin.Kotlin.StdLib.Jdk8 => 0xe3ea453135e5c19b => 189
	i64 16467346005009053642, ; 376: Xamarin.Google.Android.DataTransport.TransportApi => 0xe487c3f19e0337ca => 170
	i64 16496768397145114574, ; 377: Mono.Android.Export.dll => 0xe4f04b741db987ce => 29
	i64 16565028646146589191, ; 378: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 197
	i64 16621146507174665210, ; 379: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 101
	i64 16648892297579399389, ; 380: CommunityToolkit.Mvvm => 0xe70cbf55c4f508dd => 14
	i64 16677317093839702854, ; 381: Xamarin.AndroidX.Navigation.UI => 0xe771bb8960dd8b46 => 130
	i64 16755018182064898362, ; 382: SQLitePCLRaw.core.dll => 0xe885c843c330813a => 43
	i64 16767985610513713374, ; 383: Xamarin.Android.Arch.Core.Runtime => 0xe8b3da12798808de => 59
	i64 16822611501064131242, ; 384: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 194
	i64 16833383113903931215, ; 385: mscorlib => 0xe99c30c1484d7f4f => 30
	i64 16890310621557459193, ; 386: System.Text.RegularExpressions.dll => 0xea66700587f088f9 => 211
	i64 16895806301542741427, ; 387: Plugin.Permissions => 0xea79f6503d42f5b3 => 35
	i64 16932527889823454152, ; 388: Xamarin.Android.Support.Core.Utils.dll => 0xeafc6c67465253c8 => 71
	i64 17024911836938395553, ; 389: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 89
	i64 17031351772568316411, ; 390: Xamarin.AndroidX.Navigation.Common.dll => 0xec5b843380a769fb => 128
	i64 17037200463775726619, ; 391: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 115
	i64 17089166281881057141, ; 392: SkiaSharp.Extended.Svg => 0xed28ea30eb1a7775 => 38
	i64 17187273293601214786, ; 393: System.ComponentModel.Annotations.dll => 0xee8575ff9aa89142 => 200
	i64 17285063141349522879, ; 394: Rg.Plugins.Popup => 0xefe0e158cc55fdbf => 36
	i64 17383232329670771222, ; 395: Xamarin.Android.Support.CustomView.dll => 0xf13da5b41a1cc216 => 73
	i64 17428701562824544279, ; 396: Xamarin.Android.Support.Core.UI.dll => 0xf1df2fbaec73d017 => 70
	i64 17434242208926550937, ; 397: Xamarin.Google.Android.DataTransport.TransportRuntime => 0xf1f2deeb1f304b99 => 172
	i64 17483646997724851973, ; 398: Xamarin.Android.Support.ViewPager => 0xf2a2644fe5b6ef05 => 86
	i64 17524135665394030571, ; 399: Xamarin.Android.Support.Print => 0xf3323c8a739097eb => 81
	i64 17544493274320527064, ; 400: Xamarin.AndroidX.AsyncLayoutInflater => 0xf37a8fada41aded8 => 95
	i64 17570464675455066222, ; 401: GalaSoft.MvvmLight => 0xf3d6d487af0c606e => 23
	i64 17627500474728259406, ; 402: System.Globalization => 0xf4a176498a351f4e => 214
	i64 17643123953373031521, ; 403: FFImageLoading => 0xf4d8f7c220fc2c61 => 15
	i64 17666959971718154066, ; 404: Xamarin.Android.Support.CustomView => 0xf52da67d9f4e4752 => 73
	i64 17671790519499593115, ; 405: SkiaSharp.Views.Android => 0xf53ecfd92be3959b => 39
	i64 17677828421478984182, ; 406: Xamarin.Firebase.Installations.InterOp.dll => 0xf5544349c68f29f6 => 159
	i64 17685921127322830888, ; 407: System.Diagnostics.Debug.dll => 0xf571038fafa74828 => 206
	i64 17704177640604968747, ; 408: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 124
	i64 17710060891934109755, ; 409: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 122
	i64 17760961058993581169, ; 410: Xamarin.Android.Arch.Lifecycle.Common => 0xf67b9bfb46dbac71 => 60
	i64 17816041456001989629, ; 411: Xamarin.Forms.Maps.dll => 0xf73f4b4f90a1bbfd => 164
	i64 17827832363535584534, ; 412: Xamarin.Forms.PancakeView.dll => 0xf7692f1427c04d16 => 166
	i64 17838668724098252521, ; 413: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 46
	i64 17841643939744178149, ; 414: Xamarin.Android.Arch.Lifecycle.ViewModel => 0xf79a40a25573dfe5 => 64
	i64 17882897186074144999, ; 415: FormsViewGroup => 0xf82cd03e3ac830e7 => 22
	i64 17891337867145587222, ; 416: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 185
	i64 17892495832318972303, ; 417: Xamarin.Forms.Xaml.dll => 0xf84eea293687918f => 169
	i64 17928294245072900555, ; 418: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 196
	i64 17945795017270165205, ; 419: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0xf90c457cc05cfed5 => 170
	i64 17947624217716767869, ; 420: FFImageLoading.Platform => 0xf912c522ab34bc7d => 18
	i64 17958105683855786126, ; 421: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xf93801f92d25c08e => 61
	i64 17969331831154222830, ; 422: Xamarin.GooglePlayServices.Maps => 0xf95fe418471126ee => 180
	i64 17986907704309214542, ; 423: Xamarin.GooglePlayServices.Basement.dll => 0xf99e554223166d4e => 177
	i64 18025913125965088385, ; 424: System.Threading => 0xfa28e87b91334681 => 208
	i64 18116111925905154859, ; 425: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 94
	i64 18121036031235206392, ; 426: Xamarin.AndroidX.Navigation.Common => 0xfb7ada42d3d42cf8 => 128
	i64 18129453464017766560, ; 427: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 199
	i64 18260797123374478311, ; 428: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 110
	i64 18301997741680159453, ; 429: Xamarin.Android.Support.CursorAdapter => 0xfdfdc1fa58d8eadd => 72
	i64 18305135509493619199, ; 430: Xamarin.AndroidX.Navigation.Runtime.dll => 0xfe08e7c2d8c199ff => 129
	i64 18337470502355292274, ; 431: Xamarin.Firebase.Messaging => 0xfe7bc8440c175072 => 161
	i64 18370042311372477656, ; 432: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0xfeef80274e4094d8 => 44
	i64 18380184030268848184 ; 433: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 144
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [434 x i32] [
	i32 17, i32 109, i32 28, i32 215, i32 98, i32 136, i32 36, i32 137, ; 0..7
	i32 103, i32 179, i32 24, i32 64, i32 121, i32 38, i32 176, i32 2, ; 8..15
	i32 114, i32 4, i32 67, i32 61, i32 44, i32 108, i32 193, i32 168, ; 16..23
	i32 216, i32 10, i32 173, i32 57, i32 0, i32 43, i32 93, i32 76, ; 24..31
	i32 35, i32 6, i32 152, i32 207, i32 85, i32 45, i32 148, i32 181, ; 32..39
	i32 91, i32 123, i32 115, i32 27, i32 31, i32 49, i32 92, i32 9, ; 40..47
	i32 136, i32 171, i32 10, i32 88, i32 14, i32 84, i32 122, i32 18, ; 48..55
	i32 188, i32 31, i32 127, i32 19, i32 96, i32 108, i32 198, i32 201, ; 56..63
	i32 135, i32 118, i32 53, i32 11, i32 102, i32 142, i32 7, i32 54, ; 64..71
	i32 87, i32 55, i32 30, i32 23, i32 9, i32 27, i32 131, i32 53, ; 72..79
	i32 138, i32 16, i32 82, i32 162, i32 75, i32 173, i32 80, i32 154, ; 80..87
	i32 117, i32 89, i32 52, i32 191, i32 151, i32 177, i32 140, i32 139, ; 88..95
	i32 51, i32 54, i32 165, i32 1, i32 134, i32 109, i32 32, i32 49, ; 96..103
	i32 4, i32 215, i32 103, i32 155, i32 183, i32 86, i32 171, i32 42, ; 104..111
	i32 74, i32 66, i32 199, i32 144, i32 152, i32 200, i32 120, i32 95, ; 112..119
	i32 87, i32 139, i32 69, i32 21, i32 79, i32 3, i32 3, i32 167, ; 120..127
	i32 81, i32 34, i32 149, i32 125, i32 163, i32 77, i32 126, i32 166, ; 128..135
	i32 142, i32 141, i32 206, i32 101, i32 47, i32 0, i32 90, i32 12, ; 136..143
	i32 146, i32 99, i32 65, i32 131, i32 25, i32 119, i32 83, i32 168, ; 144..151
	i32 22, i32 160, i32 42, i32 79, i32 121, i32 118, i32 96, i32 106, ; 152..159
	i32 182, i32 147, i32 84, i32 174, i32 198, i32 114, i32 37, i32 56, ; 160..167
	i32 172, i32 52, i32 150, i32 156, i32 116, i32 113, i32 180, i32 72, ; 168..175
	i32 212, i32 203, i32 181, i32 157, i32 155, i32 56, i32 213, i32 162, ; 176..183
	i32 149, i32 50, i32 24, i32 187, i32 192, i32 66, i32 91, i32 8, ; 184..191
	i32 158, i32 39, i32 178, i32 158, i32 197, i32 202, i32 117, i32 65, ; 192..199
	i32 194, i32 5, i32 26, i32 202, i32 40, i32 190, i32 77, i32 209, ; 200..207
	i32 201, i32 63, i32 100, i32 130, i32 120, i32 161, i32 111, i32 141, ; 208..215
	i32 26, i32 129, i32 196, i32 78, i32 186, i32 74, i32 133, i32 15, ; 216..223
	i32 16, i32 146, i32 92, i32 205, i32 211, i32 51, i32 102, i32 33, ; 224..231
	i32 126, i32 13, i32 156, i32 153, i32 148, i32 8, i32 157, i32 28, ; 232..239
	i32 99, i32 193, i32 60, i32 176, i32 111, i32 216, i32 13, i32 50, ; 240..247
	i32 188, i32 106, i32 78, i32 185, i32 160, i32 210, i32 67, i32 140, ; 248..255
	i32 191, i32 104, i32 165, i32 214, i32 75, i32 209, i32 164, i32 207, ; 256..263
	i32 93, i32 63, i32 90, i32 47, i32 55, i32 174, i32 145, i32 178, ; 264..271
	i32 21, i32 153, i32 105, i32 150, i32 68, i32 132, i32 163, i32 29, ; 272..279
	i32 145, i32 116, i32 88, i32 138, i32 1, i32 113, i32 41, i32 204, ; 280..287
	i32 41, i32 82, i32 62, i32 46, i32 5, i32 143, i32 45, i32 184, ; 288..295
	i32 62, i32 68, i32 112, i32 124, i32 107, i32 97, i32 195, i32 98, ; 296..303
	i32 57, i32 205, i32 147, i32 189, i32 154, i32 71, i32 2, i32 110, ; 304..311
	i32 25, i32 76, i32 6, i32 143, i32 100, i32 175, i32 187, i32 94, ; 312..319
	i32 40, i32 134, i32 34, i32 192, i32 186, i32 159, i32 112, i32 167, ; 320..327
	i32 97, i32 208, i32 7, i32 20, i32 127, i32 12, i32 19, i32 132, ; 328..335
	i32 203, i32 33, i32 70, i32 32, i32 119, i32 135, i32 184, i32 125, ; 336..343
	i32 83, i32 179, i32 151, i32 175, i32 182, i32 105, i32 195, i32 107, ; 344..351
	i32 213, i32 212, i32 133, i32 58, i32 58, i32 190, i32 59, i32 104, ; 352..359
	i32 17, i32 20, i32 11, i32 80, i32 210, i32 85, i32 123, i32 48, ; 360..367
	i32 137, i32 169, i32 204, i32 183, i32 48, i32 69, i32 37, i32 189, ; 368..375
	i32 170, i32 29, i32 197, i32 101, i32 14, i32 130, i32 43, i32 59, ; 376..383
	i32 194, i32 30, i32 211, i32 35, i32 71, i32 89, i32 128, i32 115, ; 384..391
	i32 38, i32 200, i32 36, i32 73, i32 70, i32 172, i32 86, i32 81, ; 392..399
	i32 95, i32 23, i32 214, i32 15, i32 73, i32 39, i32 159, i32 206, ; 400..407
	i32 124, i32 122, i32 60, i32 164, i32 166, i32 46, i32 64, i32 22, ; 408..415
	i32 185, i32 169, i32 196, i32 170, i32 18, i32 61, i32 180, i32 177, ; 416..423
	i32 208, i32 94, i32 128, i32 199, i32 110, i32 72, i32 129, i32 161, ; 424..431
	i32 44, i32 144 ; 432..433
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
