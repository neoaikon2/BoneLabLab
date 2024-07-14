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
	public sealed class ModIOAPI : IDisposable
	{
		[PublicAPI]
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
		[PublicAPI]
		public Task<Result<AgreementVersionObject>>? GetCurrentAgreement(int agreementTypeId, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<AgreementVersionObject>>? GetAgreementVersion(int agreementVersionId, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<AccessTokenObject>>? SteamAuth(string appTicketBase64, string? email = null, long? dateExpires = null, bool? termsAgreed = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		public Task<Result<GetModfilesObject>>? GetModfiles(long gameId, long modId, long? id = null, long? dateAdded = null, long? dateScanned = null, int? virusStatus = null, int? virusPositive = null, long? filesize = null, string? filehash = null, string? filename = null, string? version = null, string? changelog = null, string? metadataBlob = null, long? offset = null, long? limit = null, string? sort = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		public Task<Result<ModfileObject>>? GetModfile(long gameId, long modId, long id, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		public Task<Result<GetGamesObject>>? GetGames(long? offset = null, long? limit = null, string? sort = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<GameObject>>? GetGame(long gameId, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		[PublicAPI]
		public Task<Result<UserObject>>? GetAuthenticatedUser(int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<GetUserEventsObject>>? GetUserEvents(long? id = null, long? gameId = null, long? modId = null, long? userId = null, long? dateAdded = null, string? eventType = null, long? offset = null, long? limit = null, string? sort = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<GetModsObject>>? GetUserSubscriptions(long? id = null, long? gameId = null, int? status = null, int? visible = null, long? submittedBy = null, long? dateAdded = null, long? dateUpdated = null, long? dateLive = null, int? maturityOption = null, int? monetisationOptions = null, string? name = null, string? nameId = null, long? modfile = null, string? metadataBlob = null, string? metadataKVP = null, string? tags = null, long? offset = null, long? limit = null, string? sort = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<GetModsObject>>? GetMods(long gameId, long? id = null, int? status = null, int? visible = null, long? submittedBy = null, long? dateAdded = null, long? dateUpdated = null, long? dateLive = null, int? maturityOption = null, int? monetisationOptions = null, string? name = null, string? nameId = null, long? modfile = null, string? metadataBlob = null, string? metadataKVP = null, string? tags = null, string? platformStatus = null, string? platforms = null, long? offset = null, long? limit = null, string? sort = null, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}
		[PublicAPI]
		public Task<Result<ModObject>>? GetMod(long gameId, long id, int retryCount = 5, RequestContext? context = null, CancellationToken token = default(CancellationToken))
		{
			return null;
		}

		public ModIOAPI(ILogger logger, int gameId)
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

		private static Result<T?> CancelledError<T>()
		{
			return default(Result<T>);
		}
		private Task<Result<T>> ParseError<T>(HttpResponseMessage response) where T : notnull
		{
			return null;
		}
		private Task<Result<T>> ParseSuccess<T>(HttpResponseMessage response) where T : notnull
		{
			return null;
		}
	}
}
