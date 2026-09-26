; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [434 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 121
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 175
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 31
	i32 39852199, ; 3: Plugin.Permissions => 0x26018a7 => 35
	i32 57263871, ; 4: Xamarin.Forms.Core.dll => 0x369c6ff => 162
	i32 57967248, ; 5: Xamarin.Android.Support.VersionedParcelable.dll => 0x3748290 => 85
	i32 88799905, ; 6: Acr.UserDialogs => 0x54afaa1 => 7
	i32 97056434, ; 7: CarouselView.FormsPlugin.Android => 0x5c8f6b2 => 10
	i32 101534019, ; 8: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 137
	i32 103834273, ; 9: Xamarin.Firebase.Annotations.dll => 0x63062a1 => 150
	i32 120558881, ; 10: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 137
	i32 134690465, ; 11: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 188
	i32 150321567, ; 12: GalaSoft.MvvmLight => 0x8f5b99f => 23
	i32 159306688, ; 13: System.ComponentModel.Annotations => 0x97ed3c0 => 200
	i32 160529393, ; 14: Xamarin.Android.Arch.Core.Common => 0x9917bf1 => 58
	i32 165246403, ; 15: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 98
	i32 166922606, ; 16: Xamarin.Android.Support.Compat.dll => 0x9f3096e => 68
	i32 182336117, ; 17: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 139
	i32 201930040, ; 18: Xamarin.Android.Arch.Core.Runtime => 0xc093538 => 59
	i32 205061960, ; 19: System.ComponentModel => 0xc38ff48 => 4
	i32 209399409, ; 20: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 96
	i32 212497893, ; 21: Xamarin.Forms.Maps.Android => 0xcaa75e5 => 163
	i32 219130465, ; 22: Xamarin.Android.Support.v4 => 0xd0faa61 => 84
	i32 220171995, ; 23: System.Diagnostics.Debug => 0xd1f8edb => 206
	i32 230216969, ; 24: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 115
	i32 231814094, ; 25: System.Globalization => 0xdd133ce => 214
	i32 232815796, ; 26: System.Web.Services => 0xde07cb4 => 198
	i32 261689757, ; 27: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 101
	i32 278686392, ; 28: Xamarin.AndroidX.Lifecycle.LiveData.dll => 0x109c6ab8 => 119
	i32 280482487, ; 29: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 113
	i32 318968648, ; 30: Xamarin.AndroidX.Activity.dll => 0x13031348 => 87
	i32 319314094, ; 31: Xamarin.Forms.Maps => 0x130858ae => 164
	i32 321597661, ; 32: System.Numerics => 0x132b30dd => 51
	i32 342366114, ; 33: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 117
	i32 347068432, ; 34: SQLitePCLRaw.lib.e_sqlite3.android.dll => 0x14afd810 => 44
	i32 385762202, ; 35: System.Memory.dll => 0x16fe439a => 49
	i32 389971796, ; 36: Xamarin.Android.Support.Core.UI => 0x173e7f54 => 70
	i32 441335492, ; 37: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 100
	i32 442521989, ; 38: Xamarin.Essentials => 0x1a605985 => 149
	i32 442565967, ; 39: System.Collections => 0x1a61054f => 202
	i32 450948140, ; 40: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 112
	i32 464011637, ; 41: CarouselView.FormsPlugin.Abstractions => 0x1ba84175 => 9
	i32 465846621, ; 42: mscorlib => 0x1bc4415d => 30
	i32 469710990, ; 43: System.dll => 0x1bff388e => 48
	i32 476646585, ; 44: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 113
	i32 484505379, ; 45: PanCardView => 0x1ce0f723 => 32
	i32 484808150, ; 46: Com.Android.DeskClock.dll => 0x1ce595d6 => 11
	i32 485140951, ; 47: Xamarin.Google.Android.DataTransport.TransportRuntime => 0x1ceaa9d7 => 172
	i32 486930444, ; 48: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 125
	i32 495452658, ; 49: Xamarin.Google.Android.DataTransport.TransportRuntime.dll => 0x1d8801f2 => 172
	i32 498788369, ; 50: System.ObjectModel => 0x1dbae811 => 213
	i32 507148113, ; 51: Xamarin.Google.Android.DataTransport.TransportApi.dll => 0x1e3a7751 => 170
	i32 514659665, ; 52: Xamarin.Android.Support.Compat => 0x1ead1551 => 68
	i32 520798577, ; 53: FFImageLoading.Platform => 0x1f0ac171 => 18
	i32 524864063, ; 54: Xamarin.Android.Support.Print => 0x1f48ca3f => 81
	i32 525008092, ; 55: SkiaSharp.dll => 0x1f4afcdc => 37
	i32 526420162, ; 56: System.Transactions.dll => 0x1f6088c2 => 193
	i32 527452488, ; 57: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 188
	i32 542030372, ; 58: Xamarin.GooglePlayServices.Stats => 0x204eba24 => 182
	i32 545304856, ; 59: System.Runtime.Extensions => 0x2080b118 => 209
	i32 569601784, ; 60: Xamarin.AndroidX.Window.Extensions.Core.Core => 0x21f36ef8 => 148
	i32 581545823, ; 61: FFImageLoading.Svg.Forms => 0x22a9af5f => 19
	i32 605376203, ; 62: System.IO.Compression.FileSystem => 0x24154ecb => 196
	i32 627609679, ; 63: Xamarin.AndroidX.CustomView => 0x2568904f => 106
	i32 630587553, ; 64: SkiaSharp.Extended.Svg.dll => 0x259600a1 => 38
	i32 639843206, ; 65: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 111
	i32 647512863, ; 66: Matrimony.Android.dll => 0x2698431f => 0
	i32 663517072, ; 67: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 144
	i32 666292255, ; 68: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 93
	i32 690569205, ; 69: System.Xml.Linq.dll => 0x29293ff5 => 56
	i32 691348768, ; 70: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 190
	i32 691439157, ; 71: Acr.UserDialogs.dll => 0x29368635 => 7
	i32 692692150, ; 72: Xamarin.Android.Support.Annotations => 0x2949a4b6 => 65
	i32 698030881, ; 73: FFImageLoading.Transformations => 0x299b1b21 => 21
	i32 700284507, ; 74: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 185
	i32 720511267, ; 75: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 189
	i32 748832960, ; 76: SQLitePCLRaw.batteries_v2 => 0x2ca248c0 => 42
	i32 775507847, ; 77: System.IO.Compression => 0x2e394f87 => 195
	i32 801787702, ; 78: Xamarin.Android.Support.Interpolator => 0x2fca4f36 => 77
	i32 809851609, ; 79: System.Drawing.Common.dll => 0x30455ad9 => 2
	i32 843511501, ; 80: Xamarin.AndroidX.Print => 0x3246f6cd => 132
	i32 843871832, ; 81: FFImageLoading.Svg.Forms.dll => 0x324c7658 => 19
	i32 846667644, ; 82: Xamarin.Firebase.Installations.dll => 0x32771f7c => 158
	i32 877678880, ; 83: System.Globalization.dll => 0x34505120 => 214
	i32 882434999, ; 84: Xamarin.Firebase.Installations.InterOp.dll => 0x3498e3b7 => 159
	i32 882883187, ; 85: Xamarin.Android.Support.v4.dll => 0x349fba73 => 84
	i32 902159924, ; 86: Rg.Plugins.Popup => 0x35c5de34 => 36
	i32 916714535, ; 87: Xamarin.Android.Support.Print.dll => 0x36a3f427 => 81
	i32 928116545, ; 88: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 175
	i32 955402788, ; 89: Newtonsoft.Json => 0x38f24a24 => 31
	i32 956575887, ; 90: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 189
	i32 958213972, ; 91: Xamarin.Android.Support.Media.Compat => 0x391d2f54 => 80
	i32 967690846, ; 92: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 117
	i32 974778368, ; 93: FormsViewGroup.dll => 0x3a19f000 => 22
	i32 987342438, ; 94: Xamarin.Android.Arch.Lifecycle.LiveData.dll => 0x3ad9a666 => 62
	i32 992768348, ; 95: System.Collections.dll => 0x3b2c715c => 202
	i32 996733531, ; 96: Xamarin.Google.Android.DataTransport.TransportBackendCct => 0x3b68f25b => 171
	i32 1012816738, ; 97: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 136
	i32 1031528504, ; 98: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 174
	i32 1035644815, ; 99: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 92
	i32 1036359102, ; 100: Xamarin.GooglePlayServices.CloudMessaging.dll => 0x3dc595be => 178
	i32 1042160112, ; 101: Xamarin.Forms.Platform.dll => 0x3e1e19f0 => 168
	i32 1044663988, ; 102: System.Linq.Expressions.dll => 0x3e444eb4 => 215
	i32 1052210849, ; 103: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 122
	i32 1052823365, ; 104: Com.ViewPagerIndicator => 0x3ec0cf45 => 12
	i32 1084122840, ; 105: Xamarin.Kotlin.StdLib => 0x409e66d8 => 187
	i32 1098167829, ; 106: Xamarin.Android.Arch.Lifecycle.ViewModel => 0x4174b615 => 64
	i32 1098259244, ; 107: System => 0x41761b2c => 48
	i32 1104002344, ; 108: Plugin.Media => 0x41cdbd28 => 34
	i32 1137654822, ; 109: Plugin.Permissions.dll => 0x43cf3c26 => 35
	i32 1141947663, ; 110: Xamarin.Firebase.Measurement.Connector.dll => 0x4410bd0f => 160
	i32 1149092582, ; 111: Xamarin.AndroidX.Window => 0x447dc2e6 => 147
	i32 1175144683, ; 112: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 142
	i32 1178241025, ; 113: Xamarin.AndroidX.Navigation.Runtime.dll => 0x463a8801 => 129
	i32 1204270330, ; 114: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 93
	i32 1214827643, ; 115: CommunityToolkit.Mvvm => 0x4868cc7b => 14
	i32 1243150071, ; 116: Xamarin.AndroidX.Window.Extensions.Core.Core.dll => 0x4a18f6f7 => 148
	i32 1264511973, ; 117: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 138
	i32 1267360935, ; 118: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 143
	i32 1275534314, ; 119: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 190
	i32 1278448581, ; 120: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 90
	i32 1283555170, ; 121: Xamarin.Forms.OpenWhatsApp.dll => 0x4c817f62 => 165
	i32 1292207520, ; 122: SQLitePCLRaw.core.dll => 0x4d0585a0 => 43
	i32 1292763917, ; 123: Xamarin.Android.Support.CursorAdapter.dll => 0x4d0e030d => 72
	i32 1293217323, ; 124: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 108
	i32 1297413738, ; 125: Xamarin.Android.Arch.Lifecycle.LiveData.Core => 0x4d54f66a => 61
	i32 1322716291, ; 126: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 147
	i32 1324164729, ; 127: System.Linq => 0x4eed2679 => 212
	i32 1333047053, ; 128: Xamarin.Firebase.Common => 0x4f74af0d => 151
	i32 1364015309, ; 129: System.IO => 0x514d38cd => 205
	i32 1365406463, ; 130: System.ServiceModel.Internals.dll => 0x516272ff => 199
	i32 1376866003, ; 131: Xamarin.AndroidX.SavedState => 0x52114ed3 => 136
	i32 1379779777, ; 132: System.Resources.ResourceManager => 0x523dc4c1 => 3
	i32 1379897097, ; 133: Xamarin.JavaX.Inject => 0x523f8f09 => 184
	i32 1395857551, ; 134: Xamarin.AndroidX.Media.dll => 0x5333188f => 126
	i32 1406073936, ; 135: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 102
	i32 1411638395, ; 136: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 53
	i32 1445445088, ; 137: Xamarin.Android.Support.Fragment => 0x5627bde0 => 76
	i32 1457743152, ; 138: System.Runtime.Extensions.dll => 0x56e36530 => 209
	i32 1460219004, ; 139: Xamarin.Forms.Xaml => 0x57092c7c => 169
	i32 1462112819, ; 140: System.IO.Compression.dll => 0x57261233 => 195
	i32 1469204771, ; 141: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 91
	i32 1516649851, ; 142: Xamarin.Forms.OpenWhatsApp => 0x5a663d7b => 165
	i32 1530663695, ; 143: Xamarin.Forms.Maps.dll => 0x5b3c130f => 164
	i32 1530772511, ; 144: FFImageLoading.Forms.Platform => 0x5b3dbc1f => 17
	i32 1531040989, ; 145: Xamarin.Firebase.Iid.Interop.dll => 0x5b41d4dd => 157
	i32 1543031311, ; 146: System.Text.RegularExpressions.dll => 0x5bf8ca0f => 211
	i32 1550322496, ; 147: System.Reflection.Extensions.dll => 0x5c680b40 => 5
	i32 1574652163, ; 148: Xamarin.Android.Support.Core.Utils.dll => 0x5ddb4903 => 71
	i32 1582372066, ; 149: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 107
	i32 1587447679, ; 150: Xamarin.Android.Arch.Core.Common.dll => 0x5e9e877f => 58
	i32 1592978981, ; 151: System.Runtime.Serialization.dll => 0x5ef2ee25 => 6
	i32 1597949149, ; 152: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 174
	i32 1621565679, ; 153: GalaSoft.MvvmLight.dll => 0x60a720ef => 23
	i32 1622152042, ; 154: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 124
	i32 1624863272, ; 155: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 146
	i32 1635184631, ; 156: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 111
	i32 1635482189, ; 157: FFImageLoading.Transformations.dll => 0x617b7a4d => 21
	i32 1636350590, ; 158: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 105
	i32 1639515021, ; 159: System.Net.Http.dll => 0x61b9038d => 50
	i32 1639986890, ; 160: System.Text.RegularExpressions => 0x61c036ca => 211
	i32 1657153582, ; 161: System.Runtime => 0x62c6282e => 54
	i32 1657899481, ; 162: GalaSoft.MvvmLight.Extras => 0x62d189d9 => 24
	i32 1658241508, ; 163: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 140
	i32 1658251792, ; 164: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 173
	i32 1670060433, ; 165: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 101
	i32 1677501392, ; 166: System.Net.Primitives.dll => 0x63fca3d0 => 207
	i32 1698840827, ; 167: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 186
	i32 1701541528, ; 168: System.Diagnostics.Debug.dll => 0x656b7698 => 206
	i32 1711441057, ; 169: SQLitePCLRaw.lib.e_sqlite3.android => 0x660284a1 => 44
	i32 1722051300, ; 170: SkiaSharp.Views.Forms => 0x66a46ae4 => 40
	i32 1726116996, ; 171: System.Reflection.dll => 0x66e27484 => 203
	i32 1729485958, ; 172: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 97
	i32 1731910605, ; 173: Matrimony.dll => 0x673adbcd => 27
	i32 1746316138, ; 174: Mono.Android.Export => 0x6816ab6a => 29
	i32 1765942094, ; 175: System.Reflection.Extensions => 0x6942234e => 5
	i32 1766324549, ; 176: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 139
	i32 1776026572, ; 177: System.Core.dll => 0x69dc03cc => 47
	i32 1788241197, ; 178: Xamarin.AndroidX.Fragment => 0x6a96652d => 112
	i32 1793089559, ; 179: FFImageLoading.Forms.dll => 0x6ae06017 => 16
	i32 1808609942, ; 180: Xamarin.AndroidX.Loader => 0x6bcd3296 => 124
	i32 1809303752, ; 181: Xam.Plugin.TabView.dll => 0x6bd7c8c8 => 57
	i32 1813058853, ; 182: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 187
	i32 1813201214, ; 183: Xamarin.Google.Android.Material => 0x6c13413e => 173
	i32 1818569960, ; 184: Xamarin.AndroidX.Navigation.UI.dll => 0x6c652ce8 => 130
	i32 1825341596, ; 185: Xam.Plugin.TabView => 0x6ccc809c => 57
	i32 1840964413, ; 186: FFImageLoading.Forms => 0x6dbae33d => 16
	i32 1858542181, ; 187: System.Linq.Expressions => 0x6ec71a65 => 215
	i32 1866717392, ; 188: Xamarin.Android.Support.Interpolator.dll => 0x6f43d8d0 => 77
	i32 1867746548, ; 189: Xamarin.Essentials.dll => 0x6f538cf4 => 149
	i32 1876173635, ; 190: Xamarin.Firebase.Encoders.Proto => 0x6fd42343 => 156
	i32 1878053835, ; 191: Xamarin.Forms.Xaml.dll => 0x6ff0d3cb => 169
	i32 1881862856, ; 192: Xamarin.Forms.Maps.Android.dll => 0x702af2c8 => 163
	i32 1885316902, ; 193: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 94
	i32 1900610850, ; 194: System.Resources.ResourceManager.dll => 0x71490522 => 3
	i32 1908813208, ; 195: Xamarin.GooglePlayServices.Basement => 0x71c62d98 => 177
	i32 1916660109, ; 196: Xamarin.Android.Arch.Lifecycle.ViewModel.dll => 0x723de98d => 64
	i32 1919157823, ; 197: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 127
	i32 1933215285, ; 198: Xamarin.Firebase.Messaging.dll => 0x733a8635 => 161
	i32 1959883321, ; 199: CommonServiceLocator.dll => 0x74d17239 => 13
	i32 1983156543, ; 200: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 186
	i32 2011961780, ; 201: System.Buffers.dll => 0x77ec19b4 => 46
	i32 2019465201, ; 202: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 122
	i32 2037417872, ; 203: Xamarin.Android.Support.ViewPager => 0x79708790 => 86
	i32 2044222327, ; 204: Xamarin.Android.Support.Loader => 0x79d85b77 => 78
	i32 2048185678, ; 205: Plugin.Media.dll => 0x7a14d54e => 34
	i32 2055257422, ; 206: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 118
	i32 2066383596, ; 207: FFImageLoading.Svg.Platform => 0x7b2a82ec => 20
	i32 2079903147, ; 208: System.Runtime.dll => 0x7bf8cdab => 54
	i32 2090596640, ; 209: System.Numerics.Vectors => 0x7c9bf920 => 52
	i32 2097448633, ; 210: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 114
	i32 2103459038, ; 211: SQLitePCLRaw.provider.e_sqlite3.dll => 0x7d603cde => 45
	i32 2113902067, ; 212: Xamarin.Forms.PancakeView.dll => 0x7dff95f3 => 166
	i32 2124230737, ; 213: Xamarin.Google.Android.DataTransport.TransportBackendCct.dll => 0x7e9d3051 => 171
	i32 2126786730, ; 214: Xamarin.Forms.Platform.Android => 0x7ec430aa => 167
	i32 2129483829, ; 215: Xamarin.GooglePlayServices.Base.dll => 0x7eed5835 => 176
	i32 2139458754, ; 216: Xamarin.Android.Support.DrawerLayout => 0x7f858cc2 => 75
	i32 2166116741, ; 217: Xamarin.Android.Support.Core.Utils => 0x811c5185 => 71
	i32 2174878672, ; 218: Xamarin.Firebase.Annotations => 0x81a203d0 => 150
	i32 2193016926, ; 219: System.ObjectModel.dll => 0x82b6c85e => 213
	i32 2196165013, ; 220: Xamarin.Android.Support.VersionedParcelable => 0x82e6d195 => 85
	i32 2201107256, ; 221: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 191
	i32 2201231467, ; 222: System.Net.Http => 0x8334206b => 50
	i32 2217644978, ; 223: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 142
	i32 2244775296, ; 224: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 125
	i32 2256548716, ; 225: Xamarin.AndroidX.MultiDex => 0x8680336c => 127
	i32 2261435625, ; 226: Xamarin.AndroidX.Legacy.Support.V4.dll => 0x86cac4e9 => 116
	i32 2279755925, ; 227: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 134
	i32 2315684594, ; 228: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 88
	i32 2330457430, ; 229: Xamarin.Android.Support.Core.UI.dll => 0x8ae7f556 => 70
	i32 2330986192, ; 230: Xamarin.Android.Support.SlidingPaneLayout.dll => 0x8af006d0 => 82
	i32 2340826669, ; 231: FFImageLoading.dll => 0x8b862e2d => 15
	i32 2353062107, ; 232: System.Net.Primitives => 0x8c40e0db => 207
	i32 2373288475, ; 233: Xamarin.Android.Support.Fragment.dll => 0x8d75821b => 76
	i32 2397082276, ; 234: Xamarin.Forms.PancakeView => 0x8ee092a4 => 166
	i32 2403452196, ; 235: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 110
	i32 2409053734, ; 236: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 131
	i32 2435904999, ; 237: System.ComponentModel.DataAnnotations.dll => 0x9130f5e7 => 201
	i32 2440966767, ; 238: Xamarin.Android.Support.Loader.dll => 0x917e326f => 78
	i32 2454642406, ; 239: System.Text.Encoding.dll => 0x924edee6 => 210
	i32 2465273461, ; 240: SQLitePCLRaw.batteries_v2.dll => 0x92f11675 => 42
	i32 2465532216, ; 241: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 100
	i32 2471841756, ; 242: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 243: Java.Interop.dll => 0x93918882 => 26
	i32 2483661569, ; 244: Xamarin.Firebase.Measurement.Connector => 0x9409ab01 => 160
	i32 2483742551, ; 245: Xamarin.Firebase.Messaging => 0x940ae757 => 161
	i32 2486410006, ; 246: Xamarin.GooglePlayServices.CloudMessaging => 0x94339b16 => 178
	i32 2487632829, ; 247: Xamarin.Android.Support.DocumentFile => 0x944643bd => 74
	i32 2501346920, ; 248: System.Data.DataSetExtensions => 0x95178668 => 194
	i32 2505896520, ; 249: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 121
	i32 2563143864, ; 250: AndHUD.dll => 0x98c678b8 => 8
	i32 2581819634, ; 251: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 143
	i32 2605712449, ; 252: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 191
	i32 2620111890, ; 253: Xamarin.Firebase.Encoders.dll => 0x9c2bbc12 => 154
	i32 2620871830, ; 254: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 105
	i32 2623491480, ; 255: Xamarin.Firebase.Installations.InterOp => 0x9c5f4d98 => 159
	i32 2624644809, ; 256: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 109
	i32 2633051222, ; 257: Xamarin.AndroidX.Lifecycle.LiveData => 0x9cf12c56 => 119
	i32 2639764100, ; 258: Xamarin.Firebase.Encoders => 0x9d579a84 => 154
	i32 2693849962, ; 259: System.IO.dll => 0xa090e36a => 205
	i32 2698266930, ; 260: Xamarin.Android.Arch.Lifecycle.LiveData => 0xa0d44932 => 62
	i32 2701096212, ; 261: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 140
	i32 2715334215, ; 262: System.Threading.Tasks.dll => 0xa1d8b647 => 204
	i32 2732626843, ; 263: Xamarin.AndroidX.Activity => 0xa2e0939b => 87
	i32 2737747696, ; 264: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 91
	i32 2743512811, ; 265: Matrimony => 0xa386aeeb => 27
	i32 2751899777, ; 266: Xamarin.Android.Support.Collections => 0xa406a881 => 67
	i32 2766581644, ; 267: Xamarin.Forms.Core => 0xa4e6af8c => 162
	i32 2770495804, ; 268: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 185
	i32 2778768386, ; 269: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 145
	i32 2779977773, ; 270: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 135
	i32 2788639665, ; 271: Xamarin.Android.Support.LocalBroadcastManager => 0xa63743b1 => 79
	i32 2788775637, ; 272: Xamarin.Android.Support.SwipeRefreshLayout.dll => 0xa63956d5 => 83
	i32 2795602088, ; 273: SkiaSharp.Views.Android.dll => 0xa6a180a8 => 39
	i32 2804607052, ; 274: Xamarin.Firebase.Components.dll => 0xa72ae84c => 152
	i32 2810250172, ; 275: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 102
	i32 2819470561, ; 276: System.Xml.dll => 0xa80db4e1 => 55
	i32 2821294376, ; 277: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 135
	i32 2842369275, ; 278: FFImageLoading.Forms.Platform.dll => 0xa96b1cfb => 17
	i32 2847418871, ; 279: Xamarin.GooglePlayServices.Base => 0xa9b829f7 => 176
	i32 2853208004, ; 280: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 145
	i32 2854551965, ; 281: SkiaSharp.Extended.Svg => 0xaa25019d => 38
	i32 2855708567, ; 282: Xamarin.AndroidX.Transition => 0xaa36a797 => 141
	i32 2861098320, ; 283: Mono.Android.Export.dll => 0xaa88e550 => 29
	i32 2861816565, ; 284: Rg.Plugins.Popup.dll => 0xaa93daf5 => 36
	i32 2873222696, ; 285: FFImageLoading => 0xab41e628 => 15
	i32 2876493027, ; 286: Xamarin.Android.Support.SwipeRefreshLayout => 0xab73cce3 => 83
	i32 2883826422, ; 287: Xamarin.Firebase.Installations => 0xabe3b2f6 => 158
	i32 2893257763, ; 288: Xamarin.Android.Arch.Core.Runtime.dll => 0xac739c23 => 59
	i32 2901442782, ; 289: System.Reflection => 0xacf080de => 203
	i32 2903344695, ; 290: System.ComponentModel.Composition => 0xad0d8637 => 197
	i32 2905242038, ; 291: mscorlib.dll => 0xad2a79b6 => 30
	i32 2912489636, ; 292: SkiaSharp.Views.Android => 0xad9910a4 => 39
	i32 2914202368, ; 293: Xamarin.Firebase.Iid.Interop => 0xadb33300 => 157
	i32 2916838712, ; 294: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 146
	i32 2919462931, ; 295: System.Numerics.Vectors.dll => 0xae037813 => 52
	i32 2921128767, ; 296: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 89
	i32 2921692953, ; 297: Xamarin.Android.Support.CustomView.dll => 0xae257f19 => 73
	i32 2957587826, ; 298: Xamarin.GooglePlayServices.Places.PlaceReport.dll => 0xb0493572 => 181
	i32 2959614098, ; 299: System.ComponentModel.dll => 0xb0682092 => 4
	i32 2961864971, ; 300: CommonServiceLocator => 0xb08a790b => 13
	i32 2974793899, ; 301: SkiaSharp.Views.Forms.dll => 0xb14fc0ab => 40
	i32 2978675010, ; 302: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 108
	i32 2996846495, ; 303: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 120
	i32 3016983068, ; 304: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 138
	i32 3017076677, ; 305: Xamarin.GooglePlayServices.Maps => 0xb3d4efc5 => 180
	i32 3024354802, ; 306: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 115
	i32 3044182254, ; 307: FormsViewGroup => 0xb57288ee => 22
	i32 3056250942, ; 308: Xamarin.Android.Support.AsyncLayoutInflater.dll => 0xb62ab03e => 66
	i32 3057625584, ; 309: Xamarin.AndroidX.Navigation.Common => 0xb63fa9f0 => 128
	i32 3058099980, ; 310: Xamarin.GooglePlayServices.Tasks => 0xb646e70c => 183
	i32 3068715062, ; 311: Xamarin.Android.Arch.Lifecycle.Common => 0xb6e8e036 => 60
	i32 3071899978, ; 312: Xamarin.Firebase.Common.dll => 0xb719794a => 151
	i32 3075834255, ; 313: System.Threading.Tasks => 0xb755818f => 204
	i32 3079937701, ; 314: PanCardView.dll => 0xb7941ea5 => 32
	i32 3092211740, ; 315: Xamarin.Android.Support.Media.Compat.dll => 0xb84f681c => 80
	i32 3106737866, ; 316: Xamarin.Firebase.Datatransport.dll => 0xb92d0eca => 153
	i32 3108538180, ; 317: PanCardView.Droid => 0xb9488744 => 33
	i32 3111772706, ; 318: System.Runtime.Serialization => 0xb979e222 => 6
	i32 3140389508, ; 319: GalaSoft.MvvmLight.Platform.dll => 0xbb2e8a84 => 25
	i32 3155362983, ; 320: Xamarin.Google.Android.DataTransport.TransportApi => 0xbc1304a7 => 170
	i32 3197215071, ; 321: Matrimony.Android => 0xbe91a15f => 0
	i32 3204380047, ; 322: System.Data.dll => 0xbefef58f => 192
	i32 3204912593, ; 323: Xamarin.Android.Support.AsyncLayoutInflater => 0xbf0715d1 => 66
	i32 3211777861, ; 324: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 107
	i32 3220365878, ; 325: System.Threading => 0xbff2e236 => 208
	i32 3230466174, ; 326: Xamarin.GooglePlayServices.Basement.dll => 0xc08d007e => 177
	i32 3233339011, ; 327: Xamarin.Android.Arch.Lifecycle.LiveData.Core.dll => 0xc0b8d683 => 61
	i32 3247949154, ; 328: Mono.Security => 0xc197c562 => 216
	i32 3258312781, ; 329: Xamarin.AndroidX.CardView => 0xc235e84d => 97
	i32 3267021929, ; 330: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 95
	i32 3280506390, ; 331: System.ComponentModel.Annotations.dll => 0xc3888e16 => 200
	i32 3286872994, ; 332: SQLite-net.dll => 0xc3e9b3a2 => 41
	i32 3296380511, ; 333: Xamarin.Android.Support.Collections.dll => 0xc47ac65f => 67
	i32 3299363146, ; 334: System.Text.Encoding => 0xc4a8494a => 210
	i32 3317135071, ; 335: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 106
	i32 3317144872, ; 336: System.Data => 0xc5b79d28 => 192
	i32 3321585405, ; 337: Xamarin.Android.Support.DocumentFile.dll => 0xc5fb5efd => 74
	i32 3331531814, ; 338: Xamarin.GooglePlayServices.Stats.dll => 0xc6932426 => 182
	i32 3340387945, ; 339: SkiaSharp => 0xc71a4669 => 37
	i32 3340431453, ; 340: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 94
	i32 3345895724, ; 341: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 133
	i32 3346324047, ; 342: Xamarin.AndroidX.Navigation.Runtime => 0xc774da4f => 129
	i32 3352662376, ; 343: Xamarin.Android.Support.CoordinaterLayout => 0xc7d59168 => 69
	i32 3353484488, ; 344: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 114
	i32 3357663996, ; 345: Xamarin.Android.Support.CursorAdapter => 0xc821e2fc => 72
	i32 3360279109, ; 346: SQLitePCLRaw.core => 0xc849ca45 => 43
	i32 3362522851, ; 347: Xamarin.AndroidX.Core => 0xc86c06e3 => 104
	i32 3366347497, ; 348: Java.Interop => 0xc8a662e9 => 26
	i32 3371992681, ; 349: Xamarin.Firebase.Encoders.Proto.dll => 0xc8fc8669 => 156
	i32 3372782576, ; 350: GalaSoft.MvvmLight.Platform => 0xc90893f0 => 25
	i32 3374999561, ; 351: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 134
	i32 3383578424, ; 352: Xamarin.Firebase.Encoders.JSON => 0xc9ad4f38 => 155
	i32 3395150330, ; 353: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 53
	i32 3404865022, ; 354: System.ServiceModel.Internals => 0xcaf21dfe => 199
	i32 3429136800, ; 355: System.Xml => 0xcc6479a0 => 55
	i32 3430777524, ; 356: netstandard => 0xcc7d82b4 => 1
	i32 3439690031, ; 357: Xamarin.Android.Support.Annotations.dll => 0xcd05812f => 65
	i32 3441283291, ; 358: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 109
	i32 3442543374, ; 359: AndHUD => 0xcd310b0e => 8
	i32 3476120550, ; 360: Mono.Android => 0xcf3163e6 => 28
	i32 3486566296, ; 361: System.Transactions => 0xcfd0c798 => 193
	i32 3493954962, ; 362: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 99
	i32 3494395880, ; 363: Xamarin.GooglePlayServices.Location.dll => 0xd0483fe8 => 179
	i32 3501239056, ; 364: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 95
	i32 3509114376, ; 365: System.Xml.Linq => 0xd128d608 => 56
	i32 3536029504, ; 366: Xamarin.Forms.Platform.Android.dll => 0xd2c38740 => 167
	i32 3547625832, ; 367: Xamarin.Android.Support.SlidingPaneLayout => 0xd3747968 => 82
	i32 3567349600, ; 368: System.ComponentModel.Composition.dll => 0xd4a16f60 => 197
	i32 3607250274, ; 369: Com.ViewPagerIndicator.dll => 0xd7024562 => 12
	i32 3608519521, ; 370: System.Linq.dll => 0xd715a361 => 212
	i32 3618140916, ; 371: Xamarin.AndroidX.Preference => 0xd7a872f4 => 131
	i32 3623276856, ; 372: PanCardView.Droid.dll => 0xd7f6d138 => 33
	i32 3627220390, ; 373: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 132
	i32 3632359727, ; 374: Xamarin.Forms.Platform => 0xd881692f => 168
	i32 3633644679, ; 375: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 89
	i32 3640246066, ; 376: CarouselView.FormsPlugin.Android.dll => 0xd8f9bf32 => 10
	i32 3641597786, ; 377: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 118
	i32 3645089577, ; 378: System.ComponentModel.DataAnnotations => 0xd943a729 => 201
	i32 3658720537, ; 379: CarouselView.FormsPlugin.Abstractions.dll => 0xda13a519 => 9
	i32 3664423555, ; 380: Xamarin.Android.Support.ViewPager.dll => 0xda6aaa83 => 86
	i32 3672681054, ; 381: Mono.Android.dll => 0xdae8aa5e => 28
	i32 3676310014, ; 382: System.Web.Services.dll => 0xdb2009fe => 198
	i32 3681174138, ; 383: Xamarin.Android.Arch.Lifecycle.Common.dll => 0xdb6a427a => 60
	i32 3682565725, ; 384: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 96
	i32 3684561358, ; 385: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 99
	i32 3689375977, ; 386: System.Drawing.Common => 0xdbe768e9 => 2
	i32 3706696989, ; 387: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 103
	i32 3714038699, ; 388: Xamarin.Android.Support.LocalBroadcastManager.dll => 0xdd5fbbab => 79
	i32 3718780102, ; 389: Xamarin.AndroidX.Annotation => 0xdda814c6 => 88
	i32 3724971120, ; 390: Xamarin.AndroidX.Navigation.Common.dll => 0xde068c70 => 128
	i32 3754567612, ; 391: SQLitePCLRaw.provider.e_sqlite3 => 0xdfca27bc => 45
	i32 3758932259, ; 392: Xamarin.AndroidX.Legacy.Support.V4 => 0xe00cc123 => 116
	i32 3776062606, ; 393: Xamarin.Android.Support.DrawerLayout.dll => 0xe112248e => 75
	i32 3786282454, ; 394: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 98
	i32 3822602673, ; 395: Xamarin.AndroidX.Media => 0xe3d849b1 => 126
	i32 3829621856, ; 396: System.Numerics.dll => 0xe4436460 => 51
	i32 3832731800, ; 397: Xamarin.Android.Support.CoordinaterLayout.dll => 0xe472d898 => 69
	i32 3862817207, ; 398: Xamarin.Android.Arch.Lifecycle.Runtime.dll => 0xe63de9b7 => 63
	i32 3868603669, ; 399: GalaSoft.MvvmLight.Extras.dll => 0xe6963515 => 24
	i32 3874897629, ; 400: Xamarin.Android.Arch.Lifecycle.Runtime => 0xe6f63edd => 63
	i32 3876362041, ; 401: SQLite-net => 0xe70c9739 => 41
	i32 3885922214, ; 402: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 141
	i32 3888767677, ; 403: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 133
	i32 3896760992, ; 404: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 104
	i32 3912468689, ; 405: FFImageLoading.Svg.Platform.dll => 0xe93388d1 => 20
	i32 3920810846, ; 406: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 196
	i32 3921031405, ; 407: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 144
	i32 3929156617, ; 408: Com.Android.DeskClock => 0xea322c09 => 11
	i32 3931092270, ; 409: Xamarin.AndroidX.Navigation.UI => 0xea4fb52e => 130
	i32 3934056515, ; 410: Xamarin.JavaX.Inject.dll => 0xea7cf043 => 184
	i32 3945713374, ; 411: System.Data.DataSetExtensions.dll => 0xeb2ecede => 194
	i32 3955647286, ; 412: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 92
	i32 3959773229, ; 413: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 120
	i32 3967165417, ; 414: Xamarin.GooglePlayServices.Location => 0xec7623e9 => 179
	i32 3970018735, ; 415: Xamarin.GooglePlayServices.Tasks.dll => 0xeca1adaf => 183
	i32 4015948917, ; 416: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 90
	i32 4025670099, ; 417: Xamarin.GooglePlayServices.Places.PlaceReport => 0xeff2d9d3 => 181
	i32 4025784931, ; 418: System.Memory => 0xeff49a63 => 49
	i32 4063435586, ; 419: Xamarin.Android.Support.CustomView => 0xf2331b42 => 73
	i32 4073602200, ; 420: System.Threading.dll => 0xf2ce3c98 => 208
	i32 4101593132, ; 421: Xamarin.AndroidX.Emoji2 => 0xf479582c => 110
	i32 4105002889, ; 422: Mono.Security.dll => 0xf4ad5f89 => 216
	i32 4151237749, ; 423: System.Core => 0xf76edc75 => 47
	i32 4182413190, ; 424: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 123
	i32 4184283386, ; 425: FFImageLoading.Platform.dll => 0xf96718fa => 18
	i32 4192648326, ; 426: Xamarin.Firebase.Encoders.JSON.dll => 0xf9e6bc86 => 155
	i32 4256097574, ; 427: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 103
	i32 4260525087, ; 428: System.Buffers => 0xfdf2741f => 46
	i32 4269159614, ; 429: Xamarin.Firebase.Datatransport => 0xfe7634be => 153
	i32 4274623895, ; 430: CommunityToolkit.Mvvm.dll => 0xfec99597 => 14
	i32 4278134329, ; 431: Xamarin.GooglePlayServices.Maps.dll => 0xfeff2639 => 180
	i32 4284549794, ; 432: Xamarin.Firebase.Components => 0xff610aa2 => 152
	i32 4292120959 ; 433: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 123
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [434 x i32] [
	i32 121, i32 175, i32 31, i32 35, i32 162, i32 85, i32 7, i32 10, ; 0..7
	i32 137, i32 150, i32 137, i32 188, i32 23, i32 200, i32 58, i32 98, ; 8..15
	i32 68, i32 139, i32 59, i32 4, i32 96, i32 163, i32 84, i32 206, ; 16..23
	i32 115, i32 214, i32 198, i32 101, i32 119, i32 113, i32 87, i32 164, ; 24..31
	i32 51, i32 117, i32 44, i32 49, i32 70, i32 100, i32 149, i32 202, ; 32..39
	i32 112, i32 9, i32 30, i32 48, i32 113, i32 32, i32 11, i32 172, ; 40..47
	i32 125, i32 172, i32 213, i32 170, i32 68, i32 18, i32 81, i32 37, ; 48..55
	i32 193, i32 188, i32 182, i32 209, i32 148, i32 19, i32 196, i32 106, ; 56..63
	i32 38, i32 111, i32 0, i32 144, i32 93, i32 56, i32 190, i32 7, ; 64..71
	i32 65, i32 21, i32 185, i32 189, i32 42, i32 195, i32 77, i32 2, ; 72..79
	i32 132, i32 19, i32 158, i32 214, i32 159, i32 84, i32 36, i32 81, ; 80..87
	i32 175, i32 31, i32 189, i32 80, i32 117, i32 22, i32 62, i32 202, ; 88..95
	i32 171, i32 136, i32 174, i32 92, i32 178, i32 168, i32 215, i32 122, ; 96..103
	i32 12, i32 187, i32 64, i32 48, i32 34, i32 35, i32 160, i32 147, ; 104..111
	i32 142, i32 129, i32 93, i32 14, i32 148, i32 138, i32 143, i32 190, ; 112..119
	i32 90, i32 165, i32 43, i32 72, i32 108, i32 61, i32 147, i32 212, ; 120..127
	i32 151, i32 205, i32 199, i32 136, i32 3, i32 184, i32 126, i32 102, ; 128..135
	i32 53, i32 76, i32 209, i32 169, i32 195, i32 91, i32 165, i32 164, ; 136..143
	i32 17, i32 157, i32 211, i32 5, i32 71, i32 107, i32 58, i32 6, ; 144..151
	i32 174, i32 23, i32 124, i32 146, i32 111, i32 21, i32 105, i32 50, ; 152..159
	i32 211, i32 54, i32 24, i32 140, i32 173, i32 101, i32 207, i32 186, ; 160..167
	i32 206, i32 44, i32 40, i32 203, i32 97, i32 27, i32 29, i32 5, ; 168..175
	i32 139, i32 47, i32 112, i32 16, i32 124, i32 57, i32 187, i32 173, ; 176..183
	i32 130, i32 57, i32 16, i32 215, i32 77, i32 149, i32 156, i32 169, ; 184..191
	i32 163, i32 94, i32 3, i32 177, i32 64, i32 127, i32 161, i32 13, ; 192..199
	i32 186, i32 46, i32 122, i32 86, i32 78, i32 34, i32 118, i32 20, ; 200..207
	i32 54, i32 52, i32 114, i32 45, i32 166, i32 171, i32 167, i32 176, ; 208..215
	i32 75, i32 71, i32 150, i32 213, i32 85, i32 191, i32 50, i32 142, ; 216..223
	i32 125, i32 127, i32 116, i32 134, i32 88, i32 70, i32 82, i32 15, ; 224..231
	i32 207, i32 76, i32 166, i32 110, i32 131, i32 201, i32 78, i32 210, ; 232..239
	i32 42, i32 100, i32 1, i32 26, i32 160, i32 161, i32 178, i32 74, ; 240..247
	i32 194, i32 121, i32 8, i32 143, i32 191, i32 154, i32 105, i32 159, ; 248..255
	i32 109, i32 119, i32 154, i32 205, i32 62, i32 140, i32 204, i32 87, ; 256..263
	i32 91, i32 27, i32 67, i32 162, i32 185, i32 145, i32 135, i32 79, ; 264..271
	i32 83, i32 39, i32 152, i32 102, i32 55, i32 135, i32 17, i32 176, ; 272..279
	i32 145, i32 38, i32 141, i32 29, i32 36, i32 15, i32 83, i32 158, ; 280..287
	i32 59, i32 203, i32 197, i32 30, i32 39, i32 157, i32 146, i32 52, ; 288..295
	i32 89, i32 73, i32 181, i32 4, i32 13, i32 40, i32 108, i32 120, ; 296..303
	i32 138, i32 180, i32 115, i32 22, i32 66, i32 128, i32 183, i32 60, ; 304..311
	i32 151, i32 204, i32 32, i32 80, i32 153, i32 33, i32 6, i32 25, ; 312..319
	i32 170, i32 0, i32 192, i32 66, i32 107, i32 208, i32 177, i32 61, ; 320..327
	i32 216, i32 97, i32 95, i32 200, i32 41, i32 67, i32 210, i32 106, ; 328..335
	i32 192, i32 74, i32 182, i32 37, i32 94, i32 133, i32 129, i32 69, ; 336..343
	i32 114, i32 72, i32 43, i32 104, i32 26, i32 156, i32 25, i32 134, ; 344..351
	i32 155, i32 53, i32 199, i32 55, i32 1, i32 65, i32 109, i32 8, ; 352..359
	i32 28, i32 193, i32 99, i32 179, i32 95, i32 56, i32 167, i32 82, ; 360..367
	i32 197, i32 12, i32 212, i32 131, i32 33, i32 132, i32 168, i32 89, ; 368..375
	i32 10, i32 118, i32 201, i32 9, i32 86, i32 28, i32 198, i32 60, ; 376..383
	i32 96, i32 99, i32 2, i32 103, i32 79, i32 88, i32 128, i32 45, ; 384..391
	i32 116, i32 75, i32 98, i32 126, i32 51, i32 69, i32 63, i32 24, ; 392..399
	i32 63, i32 41, i32 141, i32 133, i32 104, i32 20, i32 196, i32 144, ; 400..407
	i32 11, i32 130, i32 184, i32 194, i32 92, i32 120, i32 179, i32 183, ; 408..415
	i32 90, i32 181, i32 49, i32 73, i32 208, i32 110, i32 216, i32 47, ; 416..423
	i32 123, i32 18, i32 155, i32 103, i32 46, i32 153, i32 14, i32 180, ; 424..431
	i32 152, i32 123 ; 432..433
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
