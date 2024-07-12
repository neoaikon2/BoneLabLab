using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SLZ.ModIO.API.Utils;
using SLZ.ModIO.ApiModels;

namespace SLZ.ModIO
{
	[System.Runtime.CompilerServices.NullableContext(1)]
	[System.Runtime.CompilerServices.Nullable(0)]
	public sealed class ModIOAPI : IDisposable
	{
		[PublicAPI]
		[System.Runtime.CompilerServices.NullableContext(0)]
		public enum AgreementTypes
		{
			TermsOfUse = 1,
			PrivacyPolicy = 2,
			GameTerms = 3,
			APIAccessTerms = 4,
			MonetisationTerms = 5,
			AcceptableUsePolicy = 6
		}

		private readonly ILogger logger;

		public readonly int GameId;

		public readonly string Endpoint;

		private bool _disposed;

		public RequestContext Context { get; set; }

		public HttpClient Client { get; set; }

		public APIThrottler Throttler { get; }

		private JsonSerializer Serializer { get; }

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<AgreementVersionObject>> GetCurrentAgreement(int agreementTypeId, int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<AgreementVersionObject>> GetAgreementVersion(int agreementVersionId, int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<AccessTokenObject>> SteamAuth([System.Runtime.CompilerServices.Nullable(1)] string appTicketBase64, string email = default(string), long? dateExpires = default(long?), bool? termsAgreed = default(bool?), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		[System.Runtime.CompilerServices.NullableContext(2)]
		public Task<Result<GetModfilesObject>> GetModfiles(long gameId, long modId, long? id = default(long?), long? dateAdded = default(long?), long? dateScanned = default(long?), int? virusStatus = default(int?), int? virusPositive = default(int?), long? filesize = default(long?), string filehash = default(string), string filename = default(string), string version = default(string), string changelog = default(string), string metadataBlob = default(string), long? offset = default(long?), long? limit = default(long?), string sort = default(string), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<ModfileObject>> GetModfile(long gameId, long modId, long id, int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<GetGamesObject>> GetGames(long? offset = default(long?), long? limit = default(long?), string sort = default(string), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<GameObject>> GetGame(long gameId, int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		[System.Runtime.CompilerServices.NullableContext(2)]
		public Task<Result<UserObject>> GetAuthenticatedUser(int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<GetUserEventsObject>> GetUserEvents(long? id = default(long?), long? gameId = default(long?), long? modId = default(long?), long? userId = default(long?), long? dateAdded = default(long?), string eventType = default(string), long? offset = default(long?), long? limit = default(long?), string sort = default(string), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		[System.Runtime.CompilerServices.NullableContext(2)]
		public Task<Result<GetModsObject>> GetUserSubscriptions(long? id = default(long?), long? gameId = default(long?), int? status = default(int?), int? visible = default(int?), long? submittedBy = default(long?), long? dateAdded = default(long?), long? dateUpdated = default(long?), long? dateLive = default(long?), int? maturityOption = default(int?), int? monetisationOptions = default(int?), string name = default(string), string nameId = default(string), long? modfile = default(long?), string metadataBlob = default(string), string metadataKVP = default(string), string tags = default(string), long? offset = default(long?), long? limit = default(long?), string sort = default(string), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		[System.Runtime.CompilerServices.NullableContext(2)]
		public Task<Result<GetModsObject>> GetMods(long gameId, long? id = default(long?), int? status = default(int?), int? visible = default(int?), long? submittedBy = default(long?), long? dateAdded = default(long?), long? dateUpdated = default(long?), long? dateLive = default(long?), int? maturityOption = default(int?), int? monetisationOptions = default(int?), string name = default(string), string nameId = default(string), long? modfile = default(long?), string metadataBlob = default(string), string metadataKVP = default(string), string tags = default(string), string platformStatus = default(string), string platforms = default(string), long? offset = default(long?), long? limit = default(long?), string sort = default(string), int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		[PublicAPI]
		public Task<Result<ModObject>> GetMod(long gameId, long id, int retryCount = 5, RequestContext context = default(RequestContext), CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public ModIOAPI(ILogger logger, int gameId)
			: base()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		private void CheckDisposed()
		{
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		private static Result<T> CancelledError<T>()
		{
			return default(Result<T>);
		}

		private Task<Result<T>> ParseError<T>(HttpResponseMessage response)
		{
			return null;
		}

		private Task<Result<T>> ParseSuccess<T>(HttpResponseMessage response)
		{
			return null;
		}
	}
}
