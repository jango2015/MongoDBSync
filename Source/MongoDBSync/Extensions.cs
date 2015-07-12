using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumConcepts.MongoDBSync {
    /// <summary>Synchronous extensions for the asynchronous MongoDB .NET driver.</summary>
    public static class Extensions {
        /// <summary>Wraps the async AggregateAsync method.</summary>
        public static IAsyncCursor<TResult> Aggregate<TDocument, TResult>(this IMongoCollection<TDocument> collection, PipelineDefinition<TDocument, TResult> pipeline, AggregateOptions options = null) {
            return collection.AggregateAsync(pipeline, options).Result;
        }

        /// <summary>Wraps the async BulkWriteAsync method.</summary>
        public static BulkWriteResult<TDocument> BulkWrite<TDocument>(this IMongoCollection<TDocument> collection, IEnumerable<WriteModel<TDocument>> requests, BulkWriteOptions options = null) {
            return collection.BulkWriteAsync(requests, options).Result;
        }

        /// <summary>Wraps the async CountAsync method.</summary>
        public static long Count<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, CountOptions options = null) {
            return collection.CountAsync(filter, options).Result;
        }

        /// <summary>Wraps the async DeleteManyAsync method.</summary>
        public static DeleteResult Delete<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter) {
            return collection.DeleteMany(filter);
        }

        /// <summary>Wraps the async DeleteManyAsync method.</summary>
        public static DeleteResult DeleteMany<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter) {
            return collection.DeleteManyAsync(filter).Result;
        }

        /// <summary>Wraps the async DeleteOneAsync method.</summary>
        public static DeleteResult DeleteOne<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter) {
            return collection.DeleteOneAsync(filter).Result;
        }

        /// <summary>Wraps the async DistinctAsync method.</summary>
        public static IAsyncCursor<TField> Distinct<TDocument, TField>(this IMongoCollection<TDocument> collection, FieldDefinition<TDocument, TField> field, FilterDefinition<TDocument> filter, DistinctOptions options = null) {
            return collection.DistinctAsync(field, filter, options).Result;
        }

        /// <summary>Wraps the async FindAsync method.</summary>
        public static IAsyncCursor<TProjection> Find<TDocument, TProjection>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, FindOptions<TDocument, TProjection> options = null) {
            return collection.FindAsync(filter, options).Result;
        }

        /// <summary>Wraps the async FindOneAndDeleteAsync method.</summary>
        public static TProjection FindOneAndDelete<TDocument, TProjection>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, FindOneAndDeleteOptions<TDocument, TProjection> options = null) {
            return collection.FindOneAndDeleteAsync(filter, options).Result;
        }

        /// <summary>Wraps the async FindOneAndReplaceAsync method.</summary>
        public static TProjection FindOneAndReplace<TDocument, TProjection>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, TDocument replacement, FindOneAndReplaceOptions<TDocument, TProjection> options = null) {
            return collection.FindOneAndReplaceAsync(filter, replacement, options).Result;
        }

        /// <summary>Wraps the async FindOneAndUpdateAsync method.</summary>
        public static TProjection FindOneAndUpdate<TDocument, TProjection>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update, FindOneAndUpdateOptions<TDocument, TProjection> options = null) {
            return collection.FindOneAndUpdateAsync(filter, update, options).Result;
        }

        /// <summary>Wraps the async InsertManyAsync method.</summary>
        public static void InsertMany<TDocument>(this IMongoCollection<TDocument> collection, IEnumerable<TDocument> documents, InsertManyOptions options = null) {
            collection.InsertManyAsync(documents, options).Wait();
        }

        /// <summary>Wraps the async InsertOneAsync method.</summary>
        public static void InsertOne<TDocument>(this IMongoCollection<TDocument> collection, TDocument document) {
            collection.InsertOneAsync(document).Wait();
        }

        /// <summary>Wraps the async MapReduceAsync method.</summary>
        public static IAsyncCursor<TResult> MapReduce<TDocument, TResult>(this IMongoCollection<TDocument> collection, BsonJavaScript map, BsonJavaScript reduce, MapReduceOptions<TDocument, TResult> options = null) {
            return collection.MapReduceAsync(map, reduce, options).Result;
        }

        /// <summary>Wraps the async ReplaceOneAsync method.</summary>
        public static ReplaceOneResult ReplaceOne<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, TDocument replacement, UpdateOptions options = null) {
            return collection.ReplaceOneAsync(filter, replacement, options).Result;
        }

        /// <summary>Wraps the async UpdateManyAsync method.</summary>
        public static UpdateResult UpdateMany<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update, UpdateOptions options = null) {
            return collection.UpdateManyAsync(filter, update, options).Result;
        }

        /// <summary>Wraps the async UpdateOneAsync method.</summary>
        public static UpdateResult UpdateOne<TDocument>(this IMongoCollection<TDocument> collection, FilterDefinition<TDocument> filter, UpdateDefinition<TDocument> update, UpdateOptions options = null) {
            return collection.UpdateOneAsync(filter, update, options).Result;
        }
    }
}