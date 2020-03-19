module PackingServiceTests

open System
open NUnit.Framework
open PackingService

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()

[<Test>]
let TestEvenSequence() =
    let expected = PackingHelper.Tent
    let actual = PackingHelper.filterShelter (PackingHelper.Cloudy, PackingHelper.Rain, PackingHelper.Still, PackingHelper.Warm)
    Assert.That(actual, Is.EqualTo(expected))
