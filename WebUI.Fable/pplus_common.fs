module PPLUSbase

open Material_UI
open Fable.Core.JsInterop

module Color =
  let schalzeit : Color = Material_UI.ColorPalette.lightGreenA700
  let gleitzeit : Color = Material_UI.ColorPalette.lightGreenA700
  let kernzeit : Color = Material_UI.ColorPalette.blueA200
  let pausenkorridor : Color = Material_UI.ColorPalette.lightBlue200

  let zwangspause : Color = Material_UI.ColorPalette.orange50

  let zugeordnetes_AZModell : Color = Material_UI.ColorPalette.indigo600

  let zeitstrahlFixierungsIndikator : Color = Material_UI.ColorPalette.red600
  let zeitstrahlStandard : Color = Material_UI.ColorPalette.grey500
  let zeitstrahlGewaehlt : Color = Material_UI.ColorPalette.blueA700
  let zeitstrahlNeu : Color = Material_UI.ColorPalette.yellow600

  let validationErrorBackgroundColor : Color = Material_UI.ColorPalette.red100
  let validationErrorItemColor : Color = Material_UI.ColorPalette.red600

  let primaryColor : Color = Material_UI.ColorPalette.blue900
  let warningColor : Color = Material_UI.ColorPalette.yellow600

  let iconStandard : Color = Material_UI.ColorPalette.grey400
  let iconInactive : Color = Material_UI.ColorPalette.grey300
  let iconRed : Color = Material_UI.ColorPalette.red600
  let iconToolbar : Color = Material_UI.ColorPalette.grey500

  let textGrey : Color = Material_UI.ColorPalette.grey500
  let textBlack : Color = Material_UI.ColorPalette.black
  let textBlue : Color = Material_UI.ColorPalette.blueA700

  let backgroundHeader : Color = Material_UI.ColorPalette.grey200
  let backgroundToolTip : Color = Material_UI.ColorPalette.orange50

  let menuSelected : Color = Material_UI.ColorPalette.grey200

  let keineFarbe : Color = ""

  let overlayWhite : Color = "rgba(255,255,255,0.85)"

  let backgroundFieldWithValue : Color = Material_UI.ColorPalette.grey50

  let backgroundFieldWithoutValue : Color = Material_UI.ColorPalette.white

let jahresUndUrlaubsuebersicht =
  [
    "text" ==> Color.textGrey
    "iconStandard" ==> Color.iconStandard
    "aktuellesJahr" ==> Material_UI.ColorPalette.lightBlue700
    "feiertag" ==> Material_UI.ColorPalette.pink200
    "fehlzeiteneintraegeOhneWert" ==> Material_UI.ColorPalette.blueGrey300
    "fehlzeiteneintraegeMitWert" ==> Material_UI.ColorPalette.blueA100
    "urlaubsantraege" ==> Material_UI.ColorPalette.indigo900
    "eintrittAustritt" ==> Material_UI.ColorPalette.blueGrey100
    "ferien" ==> Material_UI.ColorPalette.amber200
    "bebuchbarerMitarbeiterstatus" ==> Material_UI.ColorPalette.green200
    "nichtBebuchbarerMitarbeiterstatus" ==> Material_UI.ColorPalette.blueGrey200
    "stichtag" ==> Material_UI.ColorPalette.grey100
    "hervorgehobenerTag" ==> Material_UI.ColorPalette.teal500
    "wochenendstage" ==> Material_UI.ColorPalette.grey300
    "urlaubskontenuebersichtWarnfarbe" ==> Material_UI.ColorPalette.red700
  ]
  |> createObj

let grouplinkedScrollbar =
  [
    "lightGrey" ==> Material_UI.ColorPalette.grey300
    "darkGrey" ==> Material_UI.ColorPalette.grey600
    "white" ==> Material_UI.ColorPalette.white
  ]
  |> createObj

let logindialog =
  [
    "grey" ==> Material_UI.ColorPalette.grey400
    "red" ==> Material_UI.ColorPalette.red800
  ]
  |> createObj

module ValidationResult =
  type T =
    | Success
    | Error of ErrorDetails
    | Unvalidated
  and ErrorDetails = string

  let updateValidationErrors id errors (result:T) =
    match result with
        | Error detail -> Map.add id detail errors
        | _ -> Map.remove id errors

  let getValidationResultFor id errors =
    match Map.tryFind id errors with
    | Some error -> Error error
    | None -> Success