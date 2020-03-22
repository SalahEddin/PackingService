module PackingServiceTests

open System
open NUnit.Framework
open PackingService
open PackingService.Models

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()

[<Test>]
let TestEvenSequence() =
    let expected = Tent
    let actual = ConditionsHelper.filterShelter (Cloudy, Rain, Still, Warm)
    Assert.That(actual, Is.EqualTo(expected))
