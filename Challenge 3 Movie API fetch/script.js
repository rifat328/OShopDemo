document.addEventListener("DOMContentLoaded", function () {
    const searchButton = document.getElementById("searchButton");
    const movieInput = document.getElementById("movieInput");
    const imdbRating = document.getElementById("imdbRating");
    const rottenTomatoes = document.getElementById("rottenTomatoes");
    const totalBudget = document.getElementById("totalBudget");
    const totalEarnings = document.getElementById("totalEarnings");

    searchButton.addEventListener("click", function () {
        const movieName = movieInput.value;
        if (movieName.trim() === "") {
            alert("Please enter a movie name.");
            return;
        }
    
    
        const apiKey = '5583d0de'; 
        const apiUrl = `http://www.omdbapi.com/?t=${encodeURIComponent(movieName)}&apikey=${apiKey}`;
    
        fetch(apiUrl)
            .then(response => response.json())
            .then(data => {
                if (data.Error) {
                    alert(data.Error);
                } else {
                    // Update the movie poster and other information
                    document.getElementById("moviePoster").src = data.Poster;
                    imdbRating.textContent = data.imdbRating;
                    const rottenTomatoesRating = data.Ratings.find(rating => rating.Source === 'Rotten Tomatoes');
                    rottenTomatoes.textContent = rottenTomatoesRating ? rottenTomatoesRating.Value : 'N/A';
                    totalBudget.textContent = data.BoxOffice || 'N/A';
                    totalEarnings.textContent = data.BoxOffice || 'N/A';
                }
            })
            .catch(error => {
                console.error(error);
                alert("An error occurred while fetching movie information.");
            });
    });
});
