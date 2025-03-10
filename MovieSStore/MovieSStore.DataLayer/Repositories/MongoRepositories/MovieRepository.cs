﻿using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MovieSStore.DataLayer.Interfaces;
using MovieSStore.Models.Configurations;
using MovieSStore.Models.DTO;


namespace MovieSStore.DataLayer.Repositories.MongoRepositories
{
    internal class MoviesRepository : IMovieRepository
    {
        private readonly IMongoCollection<Movie> _moviesCollection;
        private readonly ILogger<MoviesRepository> _logger;

        public MoviesRepository(ILogger<MoviesRepository> logger, IOptionsMonitor<MongoDbConfiguration> mongoConfig)
        {
            _logger = logger;

            if (string.IsNullOrEmpty(mongoConfig?.CurrentValue?.ConnectionString) || string.IsNullOrEmpty(mongoConfig?.CurrentValue?.DatabaseName))
            {
                _logger.LogError("MongoDb configuration is missing");

                throw new ArgumentNullException("MongoDb configuration is missing");
            }

            var client = new MongoClient(mongoConfig.CurrentValue.ConnectionString);
            var database = client.GetDatabase(mongoConfig.CurrentValue.DatabaseName);

            _moviesCollection = database.GetCollection<Movie>($"{nameof(Movie)}s");
        }

        public void AddMovie(Movie movie)
        {
            movie.Id = Guid.NewGuid().ToString();

            _moviesCollection.InsertOne(movie);
        }

        public void DeleteMovie(string id)
        {
            _moviesCollection.DeleteOne(m => m.Id == id);
        }

        public List<Movie> GetMovies()
        {
            return _moviesCollection.Find(m => true).ToList();
        }

        public Movie? GetMoviesById(string id)
        {
            return _moviesCollection.Find(m => m.Id == id).FirstOrDefault();
        }
    }
}