module Tests
open FsUnit
open Ploeh.AutoFixture.Xunit
open theLongWindedWay
open Xunit
open Xunit.Extensions
open Swensen.Unquote

[<Fact>]
let ``This is a legal name for a test`` () =
    Assert.True true

[<Theory>]
[<AutoData>]
let ``Two objects with the same names should be equal`` (lastName:string) (firstName:string) =
    let ``Name instance number one`` = new Name(lastName, firstName)
    let ``Name instance number two`` = new Name(lastName, firstName)
    ``Name instance number one`` |> should equal ``Name instance number two``

[<Theory>]
[<AutoData>]
let ``Two fsharp objects with the same names should be equal`` lastName firstName =
    let ``The first quy`` = {Fs.Name.LastName = lastName; Fs.Name.FirstName = firstName}
    let ``The other guy with the same name`` = {Fs.Name.LastName = lastName; Fs.Name.FirstName = "not really the same"}
    test <@  ``The first quy`` = ``The other guy with the same name``@>