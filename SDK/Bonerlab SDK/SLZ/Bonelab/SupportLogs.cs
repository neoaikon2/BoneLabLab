using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SLZ.Marrow.Warehouse;
using UnityEngine;
using UnityEngine.Scripting;

namespace SLZ.Bonelab
{
	[Preserve]
	public static class SupportLogs
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CNewLogFile_003Ed__3
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			private string _003ClogPath_003E5__2;

			private FileStream _003ClogFile_003E5__3;

			private StreamWriter _003Csw_003E5__4;

			private UniTask.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFillLog_003Ed__4
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public StreamWriter logStream;

			public string exeDir;

			public string logDir;

			public string filename;

			private SnakeCaseNamingStrategy _003Cns_003E5__2;

			private JsonTextWriter _003Cjtw_003E5__3;

			private AssemblyName[] _003CreferencedAssemblies_003E5__4;

			private StringBuilder _003CreferencedAssembliesSb_003E5__5;

			private ProcessModuleCollection _003Cmodules_003E5__6;

			private StringBuilder _003CmodulesSb_003E5__7;

			private JsonSerializer _003CjsonSerializer_003E5__8;

			private TaskAwaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

			private AssemblyName[] _003C_003E7__wrap8;

			private int _003C_003E7__wrap9;

			private AssemblyName _003CreferencedAssembly_003E5__11;

			private SHA256 _003Chash_003E5__12;

			private ProcessModule _003Cmodule_003E5__13;

			private List<Pallet>.Enumerator _003C_003E7__wrap13;

			private Pallet _003Cpallet_003E5__15;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CWritePropertyAsync_003Ed__5<T>
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public JsonTextWriter jtw;

			public string key;

			public T value;

			private TaskAwaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static string LogDir;

		private static string ExeDir;

		[RuntimeInitializeOnLoadMethod]
		private static void CycleLogs()
		{
		}

		[AsyncStateMachine(typeof(_003CNewLogFile_003Ed__3))]
		private static UniTaskVoid NewLogFile()
		{
			return default(UniTaskVoid);
		}

		[AsyncStateMachine(typeof(_003CFillLog_003Ed__4))]
		private static UniTask FillLog(StreamWriter logStream, string exeDir, string logDir, string filename, string utcNowStr, string localNowStr)
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(_003CWritePropertyAsync_003Ed__5<>))]
		private static UniTask WritePropertyAsync<T>(JsonTextWriter jtw, string key, T value)
		{
			return default(UniTask);
		}

		private static string _pn(this NamingStrategy ns, string key)
		{
			return null;
		}
	}
}
