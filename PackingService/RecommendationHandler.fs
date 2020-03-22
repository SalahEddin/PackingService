namespace PackingService

module RecommendationHelper =
    open PackingService.Models

    let filterShelterRecommendation data shelter = 1

    let getShelterRecommendation conditions =
        conditions
        |> ConditionsHelper.filterShelter
        |> filterShelterRecommendation  