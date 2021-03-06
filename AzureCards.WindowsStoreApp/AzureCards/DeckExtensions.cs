// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AzureCards.WindowsStoreApp;
using AzureCards.WindowsStoreApp.Models;
using Microsoft.Rest;

namespace AzureCards.WindowsStoreApp
{
    public static partial class DeckExtensions
    {
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        /// <param name='deckId'>
        /// Required.
        /// </param>
        /// <param name='cardCount'>
        /// Required.
        /// </param>
        public static DealResponseMessage Deal(this IDeck operations, string deckId, int cardCount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDeck)s).DealAsync(deckId, cardCount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        /// <param name='deckId'>
        /// Required.
        /// </param>
        /// <param name='cardCount'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<DealResponseMessage> DealAsync(this IDeck operations, string deckId, int cardCount, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<AzureCards.WindowsStoreApp.Models.DealResponseMessage> result = await operations.DealWithOperationResponseAsync(deckId, cardCount, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        public static string New(this IDeck operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDeck)s).NewAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> NewAsync(this IDeck operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.NewWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        /// <param name='deckId'>
        /// Required.
        /// </param>
        public static bool Shuffle(this IDeck operations, string deckId)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IDeck)s).ShuffleAsync(deckId);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the AzureCards.WindowsStoreApp.IDeck.
        /// </param>
        /// <param name='deckId'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<bool> ShuffleAsync(this IDeck operations, string deckId, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<bool> result = await operations.ShuffleWithOperationResponseAsync(deckId, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
