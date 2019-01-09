module Material_UI

open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
module R = Fable.Helpers.React
open R.Props

open System

type RCom = React.ComponentClass<obj>

let wrapProps props =
  keyValueList CaseRules.LowerFirst props

let wrap (wrapper:React.ReactElement list -> React.ReactElement) (wrapped:React.ReactElement) : React.ReactElement = wrapper [wrapped]

[<Emit("Object.assign({}, $0, $1)")>]
let (++) (a: 'a list) (b: 'a list) : 'a list = jsNative

[<AutoOpen>]
module PropTypes =
  type Color = string
  type [<StringEnum>] BeforeAfter =
    | [<CompiledName("before")>] Before
    | [<CompiledName("after")>] After
  type [<StringEnum>] LeftRight =
    | [<CompiledName("left")>] Left
    | [<CompiledName("right")>] Right
  type ZDepth = int
  type [<StringEnum>] CornersAndCenter =
    | [<CompiledName("bottom-center")>] BottomCenter
    | [<CompiledName("top-center")>] TopCenter
    | [<CompiledName("bottom-right")>] BottomRight
    | [<CompiledName("top-right")>] TopRight
    | [<CompiledName("bottom-left")>] BottomLeft
    | [<CompiledName("top-left")>] TopLeft
  type [<StringEnum>] DialogContainer =
    | [<CompiledName("inline")>] Inline
    | [<CompiledName("dialog")>] Dialog
  type [<StringEnum>] DialogMode =
    | [<CompiledName("portrait")>] Portrait
    | [<CompiledName("landscape")>] Landscape
  type Origin = { vertical:VerticalOrigin ; horizontal:HorizontalOrigin }
  and [<StringEnum>] HorizontalOrigin =
    | [<CompiledName("left")>] Left
    | [<CompiledName("middle")>] Middle
    | [<CompiledName("right")>] Right
  and [<StringEnum>] VerticalOrigin =
    | [<CompiledName("top")>] Top
    | [<CompiledName("center")>] Center
    | [<CompiledName("bottom")>] Bottom
  type [<StringEnum>] Axis =
    | [<CompiledName("x")>] X
    | [<CompiledName("x-reverse")>] XReverse
    | [<CompiledName("y")>] Y
    | [<CompiledName("y-reverse")>] YReverse
  type [<StringEnum>] FocusState =
    | [<CompiledName("none")>] NoFocus
    | [<CompiledName("focused")>] Focused
    | [<CompiledName("keyboard-focused")>] KeyboardFocused
  type [<StringEnum>] Orientation =
    | [<CompiledName("horizontal")>] Horizontal
    | [<CompiledName("vertical")>] Vertical
  type [<StringEnum>] ProgressMode =
    | [<CompiledName("determinate")>] Determinate
    | [<CompiledName("indeterminate")>] Indeterminate
  type [<Erase>] StringOrNumber =
    | String of string
    | Number of int
  type [<StringEnum>] RefreshIndicatorStatus =
    | [<CompiledName("ready")>] Ready
    | [<CompiledName("loading")>] Loading
    | [<CompiledName("hide")>] Hide
  type DataSource = obj list
  type DataSourceConfig = { text:string; value:string }
  let defaultDataSourceConfig = { text="text";value="value" }

module ColorPalette =
  // https://material.google.com/style/color.html#color-color-palette

  let grey50 : Color = importMember<string> "material-ui/styles/colors"
  let grey100 : Color = importMember<string> "material-ui/styles/colors"
  let grey200 : Color = importMember<string> "material-ui/styles/colors"
  let grey300 : Color = importMember<string> "material-ui/styles/colors"
  let grey400 : Color = importMember<string> "material-ui/styles/colors"
  let grey500 : Color = importMember<string> "material-ui/styles/colors"
  let grey600 : Color = importMember<string> "material-ui/styles/colors"
  let red700 : Color = importMember<string> "material-ui/styles/colors"
  let red100 : Color = importMember<string> "material-ui/styles/colors"
  let red200 : Color = importMember<string> "material-ui/styles/colors"
  let red600 : Color = importMember<string> "material-ui/styles/colors"
  let red800 : Color = importMember<string> "material-ui/styles/colors"
  let blueA100 : Color = importMember<string> "material-ui/styles/colors"
  let blueA200 : Color = importMember<string> "material-ui/styles/colors"
  let blueA700 : Color = importMember<string> "material-ui/styles/colors"
  let blue900 : Color = importMember<string> "material-ui/styles/colors"
  let blueGrey100 : Color = importMember<string> "material-ui/styles/colors"
  let blueGrey200 : Color = importMember<string> "material-ui/styles/colors"
  let blueGrey300 : Color = importMember<string> "material-ui/styles/colors"
  let lightBlue200 : Color = importMember<string> "material-ui/styles/colors"
  let lightBlue700 : Color = importMember<string> "material-ui/styles/colors"
  let white : Color = importMember<string> "material-ui/styles/colors"
  let black : Color = importMember<string> "material-ui/styles/colors"
  let indigo900 : Color = importMember<string> "material-ui/styles/colors"
  let indigo600 : Color = importMember<string> "material-ui/styles/colors"
  let orange50 : Color = importMember<string> "material-ui/styles/colors"
  let orange100 : Color = importMember<string> "material-ui/styles/colors"
  let limeA700 : Color = importMember<string> "material-ui/styles/colors"
  let green200 : Color = importMember<string> "material-ui/styles/colors"
  let lightGreenA700 : Color = importMember<string> "material-ui/styles/colors"
  let yellow600 : Color = importMember<string> "material-ui/styles/colors"
  let yellow700 : Color = importMember<string> "material-ui/styles/colors"
  let yellow800 : Color = importMember<string> "material-ui/styles/colors"
  let pink200 : Color = importMember<string> "material-ui/styles/colors"
  let amber200 : Color = importMember<string> "material-ui/styles/colors"
  let teal500 : Color = importMember<string> "material-ui/styles/colors"


module Icon =
    // https://material.io/icons/

  module Maps =
    let private _Place = importDefault<RCom> "material-ui/svg-icons/maps/place"
    let place color = R.from _Place (createObj [ "color" ==> color ]) []

  module Navigation =
    let private _MoreVert = importDefault<RCom> "material-ui/svg-icons/navigation/more-vert"
    let MoreVert color = R.from _MoreVert (createObj [ "color" ==> color ]) []

    let private _ArrowUpward = importDefault<RCom> "material-ui/svg-icons/navigation/arrow-upward"
    let ArrowUpward color = R.from _ArrowUpward (createObj [ "color" ==> color ]) []

    let private _ArrowDownward = importDefault<RCom> "material-ui/svg-icons/navigation/arrow-downward"
    let ArrowDownward color = R.from _ArrowDownward (createObj [ "color" ==> color ]) []

    let private _ChevronLeft = importDefault<RCom> "material-ui/svg-icons/navigation/chevron-left"
    let ChevronLeft color = R.from _ChevronLeft (createObj [ "color" ==> color ]) []

    let private _ChevronRight = importDefault<RCom> "material-ui/svg-icons/navigation/chevron-right"
    let ChevronRight color = R.from _ChevronRight (createObj [ "color" ==> color ]) []

    let private _Check = importDefault<RCom> "material-ui/svg-icons/navigation/check"
    let Check color = R.from _Check (createObj [ "color" ==> color ]) []

    let private _Cancel = importDefault<RCom> "material-ui/svg-icons/navigation/cancel"
    let Cancel color = R.from _Cancel (createObj [ "color" ==> color ]) []


  module Hardware =
    let private _KeyboardArrowUp = importDefault<RCom> "material-ui/svg-icons/hardware/keyboard-arrow-up"
    let KeyboardArrowUp color = R.from _KeyboardArrowUp (createObj [ "color" ==> color ]) []

    let private _KeyboardArrowDown = importDefault<RCom> "material-ui/svg-icons/hardware/keyboard-arrow-down"
    let KeyboardArrowDown color = R.from _KeyboardArrowDown (createObj [ "color" ==> color ]) []


  module Content =
    let private _AddCircle = importDefault<RCom> "material-ui/svg-icons/content/add-circle"
    let AddCircle color = R.from _AddCircle (createObj [ "color" ==> color ]) []

    let private _AddCircleOutline = importDefault<RCom> "material-ui/svg-icons/content/add-circle-outline"
    let AddCircleOutline color = R.from _AddCircleOutline (createObj [ "color" ==> color ]) []

    let private _Add = importDefault<RCom> "material-ui/svg-icons/content/add"
    let Add color = R.from _Add (createObj [ "color" ==> color ]) []

    let private _RemoveCircleOutline = importDefault<RCom> "material-ui/svg-icons/content/remove-circle-outline"
    let RemoveCircleOutline color = R.from _RemoveCircleOutline (createObj [ "color" ==> color ]) []

    let private _Archive = importDefault<RCom> "material-ui/svg-icons/content/archive"
    let Archive color = R.from _Archive (createObj [ "color" ==> color ]) []

    let private _Unarchive = importDefault<RCom> "material-ui/svg-icons/content/unarchive"
    let Unarchive color = R.from _Unarchive (createObj [ "color" ==> color ]) []

    let private _ContentCopy = importDefault<RCom> "material-ui/svg-icons/content/content-copy"
    let ContentCopy color = R.from _ContentCopy (createObj [ "color" ==> color ]) []

    let private _Redo = importDefault<RCom> "material-ui/svg-icons/content/redo"
    let Redo color = R.from _Redo (createObj [ "color" ==> color ]) []

    let private _Undo = importDefault<RCom> "material-ui/svg-icons/content/undo"
    let Undo color = R.from _Undo (createObj [ "color" ==> color ]) []

    let private _Clear = importDefault<RCom> "material-ui/svg-icons/content/clear"
    let Clear color = R.from _Clear (createObj [ "color" ==> color ]) []

    let private _Remove = importDefault<RCom> "material-ui/svg-icons/content/remove"
    let Remove color = R.from _Remove (createObj [ "color" ==> color ]) []

    let private _ContentPaste = importDefault<RCom> "material-ui/svg-icons/content/content-paste"
    let ContentPaste color = R.from _ContentPaste (createObj [ "color" ==> color ]) []

    let private _Inbox = importDefault<RCom> "material-ui/svg-icons/content/inbox"
    let Inbox color = R.from _Inbox (createObj [ "color" ==> color ]) []

  module Communication =
    let private _LocationOff = importDefault<RCom> "material-ui/svg-icons/communication/location-off"
    let locationOff color = R.from _LocationOff (createObj [ "color" ==> color ]) []

  module Action =
    let private _Delete = importDefault<RCom> "material-ui/svg-icons/action/delete"
    let Delete color = R.from _Delete (createObj [ "color" ==> color ]) []

    let private _Lock = importDefault<RCom> "material-ui/svg-icons/action/lock"
    let Lock color = R.from _Lock (createObj [ "color" ==> color ]) []

    let private _Done = importDefault<RCom> "material-ui/svg-icons/action/done"
    let Done color = R.from _Done (createObj [ "color" ==> color ]) []

    let private _HelpOutline = importDefault<RCom> "material-ui/svg-icons/action/help-outline"
    let HelpOutline color = R.from _HelpOutline (createObj [ "color" ==> color ]) []

    let private _HourglassEmpty = importDefault<RCom> "material-ui/svg-icons/action/hourglass-empty"
    let HourglassEmpty color = R.from _HourglassEmpty (createObj [ "color" ==> color ]) []

    let private _Settings = importDefault<RCom> "material-ui/svg-icons/action/settings"
    let Settings color = R.from _Settings (createObj [ "color" ==> color ]) []

  module Toggle =
    let private _Intermediate_check_box = importDefault<RCom> "material-ui/svg-icons/toggle/indeterminate-check-box"
    let Intermediate_check_box color = R.from _Intermediate_check_box (createObj ["color" ==> color]) []

  module Editor =
    let private _Mode_Edit = importDefault<RCom> "material-ui/svg-icons/editor/mode-edit"
    let Mode_Edit color = R.from _Mode_Edit (createObj [ "color" ==> color ]) []

  module Alert =
    let private _Error_Outline = importDefault<RCom> "material-ui/svg-icons/alert/error-outline"
    let Error_Outline color = R.from _Error_Outline (createObj [ "color" ==> color ]) []

  module Image =
    let private _Grid_Off = importDefault<RCom> "material-ui/svg-icons/image/grid-off"
    let Grid_Off color = R.from _Grid_Off (createObj [ "color" ==> color ]) []

    let private _Grid_On = importDefault<RCom> "material-ui/svg-icons/image/grid-on"
    let Grid_On color = R.from _Grid_On (createObj [ "color" ==> color ]) []



module Raw =
  let AppBar = importDefault<RCom> "material-ui/AppBar"
  let AutoComplete = importDefault<RCom> "material-ui/AutoComplete"
  let Avatar = importDefault<RCom> "material-ui/Avatar"
  let Badge = importDefault<RCom> "material-ui/Badge"
  let Chip = importDefault<RCom> "material-ui/Chip"
  let BottomNavigation = importMember<RCom> "material-ui/BottomNavigation"
  let BottomNavigationItem = importMember<RCom> "material-ui/BottomNavigation"
  let FlatButton = importDefault<RCom> "material-ui/FlatButton"
  let RaisedButton = importDefault<RCom> "material-ui/RaisedButton"
  let FloatingActionButton = importDefault<RCom> "material-ui/FloatingActionButton"
  let IconButton = importDefault<RCom> "material-ui/IconButton"
  let Card = importMember<RCom> "material-ui/Card"
  let CardActions = importMember<RCom> "material-ui/Card"
  let CardHeader = importMember<RCom> "material-ui/Card"
  let CardMedia = importMember<RCom> "material-ui/Card"
  let CardText = importMember<RCom> "material-ui/Card"
  let CardTitle = importMember<RCom> "material-ui/Card"
  let DatePicker = importDefault<RCom> "material-ui/DatePicker"
  let DatePickerDialog = importDefault<RCom> "material-ui/DatePicker/DatePickerDialog"
  let Dialog = importDefault<RCom> "material-ui/Dialog"
  let Divider = importDefault<RCom> "material-ui/Divider"
  let Drawer = importDefault<RCom> "material-ui/Drawer"
  let GridList = importDefault<RCom> "material-ui/GridList"
  let FontIcon = importDefault<RCom> "material-ui/FontIcon"
  let SvgIcon = importDefault<RCom> "material-ui/SvgIcon"
  let List = importMember<RCom> "material-ui/List"
  let ListItem = importMember<RCom> "material-ui/List"
  let Menu = importDefault<RCom> "material-ui/Menu"
  let MenuItem = importDefault<RCom> "material-ui/MenuItem"
  let MuiThemeProvider = importDefault<RCom> "material-ui/styles/MuiThemeProvider"
  let getMuiTheme = importDefault<System.Func<unit,obj>> "material-ui/styles/getMuiTheme"
  let IconMenu = importDefault<RCom> "material-ui/IconMenu"
  let DropDownMenu = importDefault<RCom> "material-ui/DropDownMenu"
  let Paper = importDefault<RCom> "material-ui/Paper"
  let Popover = importDefault<RCom> "material-ui/Popover"
  let CircularProgress = importDefault<RCom> "material-ui/CircularProgress"
  let LinearProgress = importDefault<RCom> "material-ui/LinearProgress"
  let RefreshIndicator = importDefault<RCom> "material-ui/RefreshIndicator"
  let SelectField = importDefault<RCom> "material-ui/SelectField"
  let Slider = importDefault<RCom> "material-ui/Slider"
  let Checkbox = importDefault<RCom> "material-ui/Checkbox"
  let RadioButton = importMember<RCom> "material-ui/RadioButton"
  let RadioButtonGroup = importMember<RCom> "material-ui/RadioButton"
  let Toggle = importDefault<RCom> "material-ui/Toggle"
  let Snackbar = importDefault<RCom> "material-ui/Snackbar"
  let Stepper = importMember<RCom> "material-ui/Stepper"
  let Step = importMember<RCom> "material-ui/Stepper"
  let StepLabel = importMember<RCom> "material-ui/Stepper"
  let StepButton = importMember<RCom> "material-ui/Stepper"
  let StepContent = importMember<RCom> "material-ui/Stepper"
  let Subheader = importDefault<RCom> "material-ui/Subheader"
  let Table = importMember<RCom> "material-ui/Table"
  let TableRow = importMember<RCom> "material-ui/Table"
  let TableRowColumn = importMember<RCom> "material-ui/Table"
  let TableHeader = importMember<RCom> "material-ui/Table"
  let TableHeaderColumn = importMember<RCom> "material-ui/Table"
  let TableBody = importMember<RCom> "material-ui/Table"
  let TableFooter = importMember<RCom> "material-ui/Table"
  let Tabs = importMember<RCom> "material-ui/Tabs"
  let Tab = importMember<RCom> "material-ui/Tabs"
  let TextField = importDefault<RCom> "material-ui/TextField"
  let TimePicker = importDefault<RCom> "material-ui/TimePicker"
  let Toolbar = importMember<RCom> "material-ui/Toolbar"
  let ToolbarGroup = importMember<RCom> "material-ui/Toolbar"
  let ToolbarSeparator = importMember<RCom> "material-ui/Toolbar"
  let ToolbarTitle = importMember<RCom> "material-ui/Toolbar"




// --- PROPS ---
module Props =

  /// Avatars can be used to represent people or object.
  type IAvatarProp = interface end
  type AvatarProp =
      /// The backgroundColor of the avatar. Does not apply to image avatars.
    | BackgroundColor of string
      /// The icon or letter's color.
    | Color of string
      /// This is the SvgIcon or FontIcon to be used inside the avatar.
    | Icon of React.ReactElement
      /// This is the size of the avatar in pixels. defaults toof '40')
    | Size of int
      /// If passed in, this component will render an img element. Otherwise, a div will be rendered.
    | Src of string
    interface IAvatarProp


  /// This component generates a small badge to the top-right of its child(ren).
  type IBadgeProp = interface end
  type BadgeProp =
      /// Override the inline-styles of the badge element.
    | BadgeStyle of CSSProp list
      /// If true, the badge will use the primary badge colors. defaults toof 'false')
    | Primary of bool
      /// If true, the badge will use the secondary badge colors. defaults toof 'false')
    | Secondary of bool
    interface IBadgeProp


  /// Chips represent complex entities in small blocks, such as a contact.
  type IChipProp = interface end
  type ChipProp =
      /// Override the background color of the chip.
    | BackgroundColor of PropTypes.Color
      /// Override the label color.
    | LabelColor of PropTypes.Color
      /// Override the inline-styles of the label.
    | LabelStyle of CSSProp list
      /// Callback function fired when the delete icon is clicked. If set, the delete icon will be shown. Signature: function(event: object) => void event:touchTap event targeting the element.
    | OnRequestDelete of (obj->unit)
    interface IChipProp


  /// This component will render any icon defined in any stylesheet included in your project. You can use sites like IcoMoon to generate custom font files, or use prebuilt fonts such as Material icons or Font Awesome either included in your project, or served from a public Content Delivery Network.
  type IFontIconProp = interface end
  type FontIconProp =
      /// This is the font color of the font icon. If not specified, this component will default to muiTheme.palette.textColor.
    | Color of string
      /// This is the icon color when the mouse hovers over the icon.
    | HoverColor of string
    interface IFontIconProp


  /// The SvgIcon component takes an SVG path element as its child, and converts it to a React component which displays the path and allows the icon to be styled and respond to mouse events.
  type ISVGIconProp = interface end
  type SVGIconProp =
      /// This is the fill color of the svg icon. If not specified, this component will default to muiTheme.palette.textColor.
    | Color of PropTypes.Color
      /// This is the icon color when the mouse hovers over the icon.
    | HoverColor of PropTypes.Color
      /// Allows you to redefine what the coordinates without units mean inside an svg element. For example, if the SVG element is 500 (width) by 200 (height), and you pass viewBox='0 0 50 20', this means that the coordinates inside the svg will go from the top left corner (0,0) to bottom right (50,20) and each unit will be worth 10px. (defaults to: ''0 0 24 24'')
    | ViewBox of string
    interface ISVGIconProp


  /// Icon Menus are menus that open from icons. They can give options related to the icon and use a minimal space.
  type IIconMenuProp = interface end
  type IconMenuProp =
      /// This is the point on the icon where the menu targetOrigin will attach. Options: vertical: [top, center, bottom] horizontal: [left, middle, right]. (defaults to: '{ vertical: 'top', horizontal: 'left',}')
    | AnchorOrigin of PropTypes.Origin
      /// If true, the popover will apply transitions when it gets added to the DOM. (defaults to: 'true')
    | Animated of bool
      /// Override the default animation component used.
    | Animation of (unit->unit)
      /// Override the inline-styles of the underlying icon element.
    | IconStyle of CSSProp list
      /// Override the inline-styles of the underlying List element.
    | ListStyle of CSSProp list
      /// Override the inline-styles of the menu element.
    | MenuStyle of CSSProp list
      /// If true, the value can an be array and allow the menu to be a multi-select. (defaults to: 'false')
    | Multiple of bool
      /// Callback function fired when a menu item is selected with a touch-tap. Signature: function(event: object, child: object) => void event: TouchTap event targeting the selected menu item element. child: The selected element. (defaults to: '(fun _ -> ())')
    | OnItemTouchTap of ((obj*obj)->unit)
      /// Callback function fired when the IconButton element is focused or blurred by the keyboard. Signature: function(event: object, keyboardFocused: boolean) => void event:focus or blur event targeting the IconButton element. keyboardFocused: If true, the IconButton element is focused. (defaults to: '(fun _ -> ())')
    | OnKeyboardFocus of ((obj*bool)->unit)
      /// Callback function fired when the open state of the menu is requested to be changed. Signature: function(open: boolean, reason: string) => void open: If true, the menu was requested to be opened. reason: The reason for the open or close request. Possible values are 'keyboard' and 'iconTap' for open requests; 'enter', 'escape', 'itemTap', and 'clickAway' for close requests. (defaults to: '(fun _ -> ())')
    | OnRequestChange of ((bool*string)->unit)
      /// If true, the IconMenu is opened. (defaults to: 'null')
    | Open of bool
      /// This is the point on the menu which will stick to the menu origin. Options: vertical: [top, center, bottom] horizontal: [left, middle, right]. (defaults to: '{ vertical: 'top', horizontal: 'left',}')
    | TargetOrigin of PropTypes.Origin
      /// Sets the delay in milliseconds before closing the menu when an item is clicked. If set to 0 then the auto close functionality will be disabled. (defaults to: '200')
    | TouchTapCloseDelay of int
      /// If true, the popover will render on top of an invisible layer, which will prevent clicks to the underlying elements. (defaults to: 'false')
    | UseLayerForClickAway of bool
    interface IIconMenuProp


  /// The DropDownMenu component is Material-UI's implementation of the Textfield dropdown.
  type IDropDownMenuProp = interface end
  type DropDownMenuProp =
      /// If true, the popover will apply transitions when it gets added to the DOM. (defaults to: 'true')
    | Animated of bool
      /// Override the default animation component used.
    | Animation of (unit->unit)
      /// The width will automatically be set according to the items inside the menu. To control this width in css instead, set this prop to false. (defaults to: 'true')
    | AutoWidth of bool
      /// Disables the menu. (defaults to: 'false')
    | Disabled of bool
      /// Overrides the styles of icon element.
    | IconStyle of CSSProp list
      /// Overrides the styles of label when the DropDownMenu is inactive.
    | LabelStyle of CSSProp list
      /// The style object to use to override underlying list style.
    | ListStyle of CSSProp list
      /// The maximum height of the Menu when it is displayed. (defaults to: '500')
    | MaxHeight of int
      /// Overrides the styles of Menu when the DropDownMenu is displayed.
    | MenuStyle of CSSProp list
      /// Callback function fired when a menu item is clicked, other than the one currently selected. Signature: function(event: object, key: number, payload: any) => void event: TouchTap event targeting the menu item that was clicked. key: The index of the clicked menu item in the children collection. payload: The value prop of the clicked menu item.
    | OnChange of ((obj*int*obj)->unit)
      /// Callback function fired when the menu is closed.
    | OnClose of (unit->unit)
      /// Set to true to have the DropDownMenu automatically open on mount. (defaults to: 'false')
    | OpenImmediately of bool
      /// Overrides the inline-styles of the underline.
    | UnderlineStyle of CSSProp list
      /// The value that is currently selected.
    | Value of obj
    interface IDropDownMenuProp


  /// Snackbars provide lightweight feedback about an operation by showing a brief message at the bottom of the screen. Snackbars can contain an action.
  type ISnackbarProp = interface end
  type SnackbarProp =
      /// The label for the action on the snackbar.
    | Action of React.ReactElement
      /// The number of milliseconds to wait before automatically dismissing. If no value is specified the snackbar will dismiss normally. If a value is provided the snackbar can still be dismissed normally. If a snackbar is dismissed before the timer expires, the timer will be cleared.
    | AutoHideDuration of int
      /// Override the inline-styles of the body element.
    | BodyStyle of CSSProp list
      /// Override the inline-styles of the content element.
    | ContentStyle of CSSProp list
      /// Fired when the action button is touchtapped. Signature: function(event: object) => void event: Action button event.
    | OnActionTouchTap of (obj->unit)
      /// Fired when the Snackbar is requested to be closed by a click outside the Snackbar, or after the autoHideDuration timer expires. Typically onRequestClose is used to set state in the parent component, which is used to control the Snackbaropen prop. The reason parameter can optionally be used to control the response to onRequestClose, for example ignoring clickaway. Signature: function(reason: string) => void reason: Can be:'timeout' (autoHideDuration expired) or: 'clickaway'
    | OnRequestClose of (string->unit)
    interface ISnackbarProp


  /// Subheaders are special list tiles that delineate distinct sections of a list or grid list and are typically related to the current filtering or sorting criteria.
  type ISubheaderProp = interface end
  type SubheaderProp =
      /// If true, the Subheader will be indented. (defaults to: 'false')
    | Inset of bool
    interface ISubheaderProp


  /// Lists are used to present multiple items vertically as a single continuous element. They can be configured for many uses such as a contacts list, nested lists, etc.
  type IListProp = interface end


  /// Lists are used to present multiple items vertically as a single continuous element. They can be configured for many uses such as a contacts list, nested lists, etc.
  type IListItemProp = interface end
  type ListItemProp =
      /// If true, generate a nested-list-indicator icon when nested list items are detected. Note that an indicator will not be created if a rightIcon or rightIconButton has been provided to the element. (defaults to: 'true')
    | AutoGenerateNestedIndicator of bool
      /// If true, the element will not be able to be focused by the keyboard. (defaults to: 'false')
    | DisableKeyboardFocus of bool
      /// If true, the element will not be clickable and will not display hover effects. This is automatically disabled if either leftCheckbox or rightToggle is set. (defaults to: 'false')
    | Disabled of bool
      /// Override the hover background color.
    | HoverColor of PropTypes.Color
      /// If true, the nested ListItems are initially displayed. (defaults to: 'false')
    | InitiallyOpen of bool
      /// Override the inline-styles of the inner div element.
    | InnerDivStyle of CSSProp list
      /// If true, the children will be indented by 72px. This is useful if there is no left avatar or left icon. (defaults to: 'false')
    | InsetChildren of bool
      /// This is the Avatar element to be displayed on the left side.
    | LeftAvatar of React.ReactElement
      /// This is the Checkbox element to be displayed on the left side.
    | LeftCheckbox of React.ReactElement
      /// This is the SvgIcon or FontIcon to be displayed on the left side.
    | LeftIcon of React.ReactElement
      /// An array of ListItems to nest underneath the current ListItem. (defaults to: '[]')
    | NestedItems of React.ReactElement list
      /// Controls how deep a ListItem appears. This property is automatically managed, so modify at your own risk. (defaults to: '0')
    | NestedLevel of int
      /// Override the inline-styles of the nested items' NestedList.
    | NestedListStyle of CSSProp list
      /// Callback function fired when the ListItem is focused or blurred by the keyboard. Signature: function(event: object, isKeyboardFocused: boolean) => void event:focus or blur event targeting the ListItem. isKeyboardFocused: If true, the ListItem is focused. (defaults to: '(fun _ -> ())')
    | OnKeyboardFocus of ((obj*bool)->unit)
      /// Callbak function fired when the ListItem toggles its nested list. Signature: function(listItem: object) => void listItem: The ListItem. (defaults to: '(fun _ -> ())')
    | OnNestedListToggle of (obj->unit)
      /// Control toggle state of nested list. (defaults to: 'null')
    | Open of bool
      /// This is the block element that contains the primary text. If a string is passed in, a div tag will be rendered.
    | PrimaryText of React.ReactElement
      /// If true, clicking or tapping the primary text of the ListItem toggles the nested list. (defaults to: 'false')
    | PrimaryTogglesNestedList of bool
      /// This is the Avatar element to be displayed on the right side.
    | RightAvatar of React.ReactElement
      /// This is the SvgIcon or FontIcon to be displayed on the right side.
    | RightIcon of React.ReactElement
      /// This is the IconButton to be displayed on the right side. Hovering over this button will remove the ListItem hover. Also, clicking on this button will not trigger a ripple on the ListItem; the event will be stopped and prevented from bubbling up to cause a ListItem click.
    | RightIconButton of React.ReactElement
      /// This is the Toggle element to display on the right side.
    | RightToggle of React.ReactElement
      /// This is the block element that contains the secondary text. If a string is passed in, a div tag will be rendered.
    | SecondaryText of React.ReactElement
      /// Can be 1 or 2. This is the number of secondary text lines before ellipsis will show. (defaults to: '1')
    | SecondaryTextLines of int
    interface IListItemProp


  /// Menus allow you to take an action by selecting from a list revealed upon opening a temporary, new sheet of material.
  type IMenuProp = interface end
  type MenuProp =
      /// If true, the width of the menu will be set automatically according to the widths of its children, using proper keyline increments (64px for desktop, 56px otherwise). (defaults to: 'true')
    | AutoWidth of bool
      /// If true, the menu item will render with compact desktop styles. (defaults to: 'false')
    | Desktop of bool
      /// If true, the menu will not be auto-focused. (defaults to: 'false')
    | DisableAutoFocus of bool
      /// If true, the menu will be keyboard-focused initially. (defaults to: 'false')
    | InitiallyKeyboardFocused of bool
      /// Override the inline-styles of the underlying List element.
    | ListStyle of CSSProp list
      /// The maximum height of the menu in pixels. If specified, the menu will be scrollable if it is taller than the provided height. (defaults to: 'null')
    | MaxHeight of int
      /// If true, value must be an array and the menu will support multiple selections. (defaults to: 'false')
    | Multiple of bool
      /// Callback function fired when a menu item with value not equal to the current value of the menu is touch-tapped. Signature: function(event: object, value: any) => void event: TouchTap event targeting the menu item. value: If multiple is true, the menu's value array with either the menu item's value added (if it wasn't already selected) or omitted (if it was already selected). Otherwise, the value of the menu item. (defaults to: '(fun _ -> ())')
    | OnChange of ((obj*obj)->unit)
      /// Callback function fired when the menu is focused and the Esc key is pressed. Signature: function(event: object) => void event:keydown event targeting the menu. (defaults to: '(fun _ -> ())')
    | OnEscKeyDown of (obj->unit)
      /// Callback function fired when a menu item is touch-tapped. Signature: function(event: object, menuItem: object, index: number) => void event: TouchTap event targeting the menu item. menuItem: The menu item. index: The index of the menu item. (defaults to: '(fun _ -> ())')
    | OnItemTouchTap of ((obj*obj*int)->unit)
      /// Override the inline-styles of selected menu items.
    | SelectedMenuItemStyle of CSSProp list
      /// If multiple is true, an array of the values of the selected menu items. Otherwise, the value of the selected menu item. If provided, the menu will be a controlled component. This component also supports valueLink.
    | Value of obj
      /// ValueLink for the menu's value.
    | ValueLink of obj
      /// The width of the menu. If not specified, the menu's width will be set according to the widths of its children, using proper keyline increments (64px for desktop, 56px otherwise).
    | Width of PropTypes.StringOrNumber
    interface IMenuProp


  /// Menus allow you to take an action by selecting from a list revealed upon opening a temporary, new sheet of material.
  type IMenuItemProp = interface end
  type MenuItemProp =
      /// Override the default animation component used.
    | Animation of (unit->unit)
      /// If true, a left check mark will be rendered. (defaults to: 'false')
    | Checked of bool
      /// If true, the menu item will be disabled. (defaults to: 'false')
    | Disabled of bool
      /// The focus state of the menu item. This prop is used to set the focus state of the underlying ListItem. (defaults to: 'NoFocus')
    | FocusState of PropTypes.FocusState
      /// Override the inline-styles of the inner div.
    | InnerDivStyle of CSSProp list
      /// If true, the children will be indented. This is only needed when there is no leftIcon. (defaults to: 'false')
    | InsetChildren of bool
      /// The SvgIcon or FontIcon to be displayed on the left side.
    | LeftIcon of React.ReactElement
      /// MenuItem elements to nest within the menu item.
    | MenuItems of React.ReactElement list
      /// Can be used to render primary text within the menu item.
    | PrimaryText of React.ReactElement
      /// The SvgIcon or FontIcon to be displayed on the right side.
    | RightIcon of React.ReactElement
      /// Can be used to render secondary text within the menu item.
    | SecondaryText of React.ReactElement
      /// The value of the menu item.
    | Value of obj
    interface IMenuItemProp


  /// Flat Buttons are used for general functions and reduce the amount of layering on the screen, making it more readable.
  type IFlatButtonProp = interface end
  type FlatButtonProp =
      /// Color of button when mouse is not hovering over it.
    | BackgroundColor of string
      /// Disables the button if set to true. (defaults to: 'false')
    | Disabled of bool
      /// Color of button when mouse hovers over.
    | HoverColor of PropTypes.Color
      /// The URL to link to when the button is clicked.
    | Href of string
      /// Use this property to display an icon.
    | Icon of React.ReactElement
      /// Label for the button.
    | Label of string
      /// Place label before or after the passed children. (defaults to: 'BeforeAfter.after'')
    | LabelPosition of PropTypes.BeforeAfter
      /// Override the inline-styles of the button's label element.
    | LabelStyle of CSSProp list
      /// Callback function fired when the element is focused or blurred by the keyboard. Signature: function(event: object, isKeyboardFocused: boolean) => void event:focus or blur event targeting the element. isKeyboardFocused: Indicates whether the element is focused. (defaults to: '(fun (e,isKeyboardFocused) -> ())')
    | OnKeyboardFocus of ((obj*bool)->unit)
      /// If true, colors button according to primaryTextColor from the Theme. (defaults to: 'false')
    | Primary of bool
      /// Color for the ripple after button is clicked.
    | RippleColor of PropTypes.Color
      /// If true, colors button according to secondaryTextColor from the theme. The primary prop has precendent if set to true. (defaults to: 'false')
    | Secondary of bool
      /// If true, the button will get the focus if mounted to the DOM
    | KeyboardFocused of bool
    interface IFlatButtonProp


  /// This button is used to add dimension to mostly flat layouts and emphasizes important functions on your page.
  type IRaisedButtonProp = interface end
  type RaisedButtonProp =
      /// Override the default background color for the button, but not the default disabled background color (use disabledBackgroundColor for this).
    | BackgroundColor of PropTypes.Color
      /// Override the inline-styles of the button element.
    | ButtonStyle of CSSProp list
      /// If true, the button will be disabled. (defaults to: 'false')
    | Disabled of bool
      /// Override the default background color for the button when it is disabled.
    | DisabledBackgroundColor of PropTypes.Color
      /// The color of the button's label when the button is disabled.
    | DisabledLabelColor of PropTypes.Color
      /// If true, the button will take up the full width of its container. (defaults to: 'false')
    | FullWidth of bool
      /// The URL to link to when the button is clicked.
    | Href of string
      /// An icon to be displayed within the button.
    | Icon of React.ReactElement
      /// The label to be displayed within the button. If content is provided via the children prop, that content will be displayed in addition to the label provided here.
    | Label of React.ReactElement
      /// The color of the button's label.
    | LabelColor of PropTypes.Color
      /// The position of the button's label relative to the button's children. (defaults to: 'Proptypes.BeforeAfter.After')
    | LabelPosition of PropTypes.BeforeAfter
      /// Override the inline-styles of the button's label element.
    | LabelStyle of CSSProp list
      /// Override the inline style of the button overlay.
    | OverlayStyle of CSSProp list
      /// If true, the button will use the theme's primary color. (defaults to: 'false')
    | Primary of bool
      /// Override the inline style of the ripple element.
    | RippleStyle of CSSProp list
      /// If true, the button will use the theme's secondary color. If both secondary and primary are true, the button will use the theme's primary color. (defaults to: 'false')
    | Secondary of bool
    interface IRaisedButtonProp


  /// The Floating Action Button is used for frequently used functions.
  type IFloatingActionButtonProp = interface end
  type FloatingActionButtonProp =
      /// This value will override the default background color for the button. However it will not override the default disabled background color. This has to be set separately using the disabledColor attribute.
    | BackgroundColor of PropTypes.Color
      /// Disables the button if set to true. (defaults to: 'false')
    | Disabled of bool
      /// This value will override the default background color for the button when it is disabled.
    | DisabledColor of PropTypes.Color
      /// The URL to link to when the button is clicked.
    | Href of string
      /// The icon within the FloatingActionButton is a FontIcon component. This property is the classname of the icon to be displayed inside the button. An alternative to adding an iconClassName would be to manually insert a FontIcon component or custom SvgIcon component or as a child of FloatingActionButton.
    | IconClassName of string
      /// This is the equivalent to iconClassName except that it is used for overriding the inline-styles of the FontIcon component.
    | IconStyle of CSSProp list
      /// If true, the button will be a small floating action button. (defaults to: 'false')
    | Mini of bool
      /// If true, the button will use the secondary button colors. (defaults to: 'false')
    | Secondary of bool
      /// The zDepth of the underlying Paper component. (defaults to: '2')
    | ZDepth of PropTypes.ZDepth
    interface IFloatingActionButtonProp


  /// An Icon Button generates a button element around an icon. Also, focus styles will happen on tab but not on click. There are three ways to add an icon:
  type IIconButtonProp = interface end
  type IconButtonProp =
      /// If true, the element's ripple effect will be disabled. (defaults to: 'false')
    | DisableTouchRipple of bool
      /// If true, the element will be disabled. (defaults to: 'false')
    | Disabled of bool
      /// Override the inline-styles of the root element when the component is hovered.
    | HoveredStyle of CSSProp list
      /// The URL to link to when the button is clicked.
    | Href of string
      /// The CSS class name of the icon. Used for setting the icon with a stylesheet.
    | IconClassName of string
      /// Override the inline-styles of the icon element. (defaults to: '{}')
    | IconStyle of CSSProp list
      /// Callback function fired when the element is focused or blurred by the keyboard. Signature: function(event: object, isKeyboardFocused: boolean) => void event:focus or blur event targeting the element. isKeyboardFocused: Indicates whether the element is focused. (defaults to: '(fun (e,isKeyboardFocused) -> ())')
    | OnKeyboardFocus of ((obj*bool)->unit)
      /// The text to supply to the element's tooltip.
    | Tooltip of React.ReactElement
      /// The vertical and horizontal positions, respectively, of the element's tooltip. Possible values are: 'bottom-center', 'top-center', 'bottom-right', 'top-right', 'bottom-left', and 'top-left'. (defaults to: 'PropTypes.CornersAndCenter.BottomCenter')
    | TooltipPosition of PropTypes.CornersAndCenter
      /// Override the inline-styles of the tooltip element.
    | TooltipStyles of CSSProp list
      /// If true, increase the tooltip element's size. Useful for increasing tooltip readability on mobile devices. (defaults to: 'false')
    | Touch of bool
    interface IIconButtonProp

  let inline IconButtonIconStyle style = !!("iconStyle", style |> wrapProps)

  /// The auto-complete is an extension of a regular text-field that will auto-complete the input dynamically. It can take different auto-complete filters and uses a menu to display suggestions.
  type IAutoCompleteProp = interface end
  type AutoCompleteProp =
      /// Location of the anchor for the auto complete. (defaults to: '{ vertical: 'bottom', horizontal: 'left',}')
    | AnchorOrigin of PropTypes.Origin
      /// If true, the auto complete is animated as it is toggled. (defaults to: 'true')
    | Animated of bool
      /// Override the default animation component used.
    | Animation of (unit->unit)
      /// Config for objects list dataSource. (defaults to: 'PropTypes.defaultDataSourceConfig')
    | DataSourceConfig of PropTypes.DataSourceConfig
      /// Disables focus ripple when true. (defaults to: 'true')
    | DisableFocusRipple of bool
      /// Override style prop for error.
    | ErrorStyle of CSSProp list
      /// The error content to display.
    | ErrorText of React.ReactElement
      /// Callback function used to filter the auto complete. Signature: function(searchText: string, key: string) => boolean searchText: The text to search for within dataSource. key:dataSource element, or text property on that element if it's not a string. returns (boolean): true indicates the auto complete list will include key when the input is searchText. (defaults to: '(fun (searchText, key) -> searchText <> '' && key.Contains(searchText))')
    | Filter of ((string*string)->bool)
      /// The content to use for adding floating label element.
    | FloatingLabelText of React.ReactElement
      /// If true, the field receives the property width: 100%. (defaults to: 'false')
    | FullWidth of bool
      /// The hint content to display.
    | HintText of React.ReactElement
      /// Override style for list.
    | ListStyle of CSSProp list
      /// The max number of search results to be shown. By default it shows all the items which matches filter.
    | MaxSearchResults of int
      /// Delay for closing time of the menu. (defaults to: '300')
    | MenuCloseDelay of int
      /// Props to be passed to menu.
    | MenuProps of obj
      /// Override style for menu.
    | MenuStyle of CSSProp list
      /// Callback function fired when the menu is closed.
    | OnClose of (unit->unit)
      /// Callback function that is fired when a list item is selected, or enter is pressed in the TextField. Signature: function(chosenRequest: string, index: number) => void chosenRequest: Either the TextField input value, if enter is pressed in the TextField, or the text value of the corresponding list item that was selected. index: The index in dataSource of the list item selected, or -1 if enter is pressed in the TextField. (defaults to: '(fun () -> ())')
    | OnNewRequest of (unit->unit)
      /// Callback function that is fired when the user updates the TextField. Signature: function(searchText: string, dataSource: array, params: object) => void searchText: The auto-complete's searchText value. dataSource: The auto-complete's dataSource array. params: Additional information linked the update. (defaults to: '(fun () -> ())')
    | OnUpdateInput of (unit->unit)
      /// Auto complete menu is open if true. (defaults to: 'false')
    | Open of bool
      /// If true, the list item is showed when a focus event triggers. (defaults to: 'false')
    | OpenOnFocus of bool
      /// Props to be passed to popover.
    | PopoverProps of obj
      /// Text being input to auto complete. (defaults to: '''')
    | SearchText of string
      /// Origin for location of target. (defaults to: '{ vertical: 'top', horizontal: 'left',}')
    | TargetOrigin of PropTypes.Origin
      /// Override the inline-styles of AutoComplete's TextField element.
    | TextFieldStyle of CSSProp list
    interface IAutoCompleteProp


  /// Date Pickers are used to select a single date for an input.
  type IDatePickerProp = interface end
  type DatePickerProp =
      /// Constructor for date formatting for the specified locale. The constructor must follow this specification: ECMAScript Internationalization API 1.0 (ECMA-402). Intl.DateTimeFormat is supported by most modern browsers, see http://caniuse.com/#search=intl, otherwise https://github.com/andyearnshaw/Intl.js is a good polyfill. By default, a built-in DateTimeFormat is used which supports the 'en-US' locale.
    | DateTimeFormat of (unit->unit)
      /// If true, automatically accept and close the picker on select a date. (defaults to: 'false')
    | AutoOk of bool
      /// Override the default text of the 'Cancel' button.
    | CancelLabel of React.ReactElement
      /// Used to control how the Date Picker will be displayed when the input field is focused. dialog (default) displays the DatePicker as a dialog with a modal. inline displays the DatePicker below the input field (similar to auto complete). (defaults to: 'PropTypes.DialogContainer.Dialog')
    | Container of PropTypes.DialogContainer
      /// This is the initial date value of the component. If either value or valueLink is provided they will override this prop with value taking precedence.
    | DefaultDate of DateTime
      /// Override the inline-styles of DatePickerDialog's Container element.
    | DialogContainerStyle of CSSProp list
      /// Disables the year selection in the date picker. (defaults to: 'false')
    | DisableYearSelection of bool
      /// Disables the DatePicker. (defaults to: 'false')
    | Disabled of bool
      /// Used to change the first day of week. It varies from Saturday to Monday between different locales. The allowed range is 0 (Sunday) to 6 (Saturday). The default is 1, Monday, as per ISO 8601. (defaults to: '1')
    | FirstDayOfWeek of int
      /// This function is called to format the date displayed in the input field, and should return a string. By default if no locale and DateTimeFormat is provided date objects are formatted to ISO 8601 YYYY-MM-DD. Signature: function(date: object) => any date: Date object to be formatted. returns (any): The formatted date.
    | FormatDate of (DateTime->string)
      /// Locale used for formatting the DatePicker date strings. Other than for 'en-US', you must provide a DateTimeFormat that supports the chosen locale.
    | Locale of string
      /// The ending of a range of valid dates. The range includes the endDate. The default value is current date + 100 years.
    | MaxDate of DateTime
      /// The beginning of a range of valid dates. The range includes the startDate. The default value is current date - 100 years.
    | MinDate of DateTime
      /// Tells the component to display the picker in portrait or landscape mode.
    | Mode of PropTypes.DialogMode
      /// Override the default text of the 'OK' button.
    | OkLabel of React.ReactElement
      /// Callback function that is fired when the date value changes. Signature: function(null: undefined, date: object) => void null: Since there is no particular event associated with the change, the first argument will always be null. date: The new date.
    | OnChange of (System.Func<unit,DateTime,unit>)
      /// Callback function that is fired when the Date Picker's dialog is dismissed.
    | OnDismiss of (unit->unit)
      /// Callback function that is fired when the Date Picker's TextField gains focus.
    | OnFocus of (unit->unit)
      /// Callback function that is fired when the Date Picker's dialog is shown.
    | OnShow of (unit->unit)
      /// Callback function used to determine if a day's entry should be disabled on the calendar. Signature: function(day: object) => boolean day: Date object of a day. returns (boolean): Indicates whether the day should be disabled.
    | ShouldDisableDate of (DateTime->bool)
      /// Override the inline-styles of DatePicker's TextField element.
    | TextFieldStyle of CSSProp list
      /// Sets the date for the Date Picker programmatically.
    | Value of DateTime
    interface IDatePickerProp


  type IDatePickerDialogProp = interface end
  type DatePickerDialogProp =
      /// Constructor for date formatting for the specified locale. The constructor must follow this specification: ECMAScript Internationalization API 1.0 (ECMA-402). Intl.DateTimeFormat is supported by most modern browsers, see http://caniuse.com/#search=intl, otherwise https://github.com/andyearnshaw/Intl.js is a good polyfill. By default, a built-in DateTimeFormat is used which supports the 'en-US' locale.
    | [<CompiledName("DateTimeFormat")>] DateTimeFormat of obj
      /// If true, automatically accept and close the picker on select a date. (defaults to: 'false')
    | AutoOk of bool
      /// Override the default text of the 'Cancel' button.
    | CancelLabel of React.ReactElement
      /// Used to control how the Date Picker will be displayed when the input field is focused. dialog (default) displays the DatePicker as a dialog with a modal. inline displays the DatePicker below the input field (similar to auto complete). (defaults to: 'PropTypes.DialogContainer.Dialog')
    | Container of PropTypes.DialogContainer
      /// Override the inline-styles of DatePickerDialog's Container element.
    | ContainerStyle of CSSProp list
      /// Disables the year selection in the date picker. (defaults to: 'false')
    | DisableYearSelection of bool
      /// Used to change the first day of week. It varies from Saturday to Monday between different locales. The allowed range is 0 (Sunday) to 6 (Saturday). The default is 1, Monday, as per ISO 8601. (defaults to: '1')
    | FirstDayOfWeek of int
      /// This is the initial date value of the component. If either value or valueLink is provided they will override this prop with value taking precedence.
    | InitialDate of DateTime
      /// Locale used for formatting the DatePicker date strings. Other than for 'en-US', you must provide a DateTimeFormat that supports the chosen locale.
    | Locale of string
      /// The ending of a range of valid dates. The range includes the endDate. The default value is current date + 100 years.
    | MaxDate of DateTime
      /// The beginning of a range of valid dates. The range includes the startDate. The default value is current date - 100 years.
    | MinDate of DateTime
      /// Tells the component to display the picker in portrait or landscape mode.
    | Mode of PropTypes.DialogMode
      /// Override the default text of the 'OK' button.
    | OkLabel of React.ReactElement
      /// Callback function that is fired when OK is clicked Signature: function(date: object) => void
    | OnAccept of (DateTime->unit)
      /// Callback function that is fired when the Date Picker's dialog is dismissed.
    | OnDismiss of (unit->unit)
      ///
    | Open of bool
      /// Callback function that is fired when the Date Picker's dialog is shown.
    | OnShow of (unit->unit)
      /// Callback function used to determine if a day's entry should be disabled on the calendar. Signature: function(day: object) => boolean day: Date object of a day. returns (boolean): Indicates whether the day should be disabled.
    | ShouldDisableDate of (DateTime->bool)
    interface IDatePickerDialogProp


  /// To learn more about SelectField please visit the specifications here.
  type ISelectFieldProp = interface end
  type SelectFieldProp<'value> =
      /// If true, the width will automatically be set according to the items inside the menu. To control the width in CSS instead, leave this prop set to false. (defaults to: 'false')
    | AutoWidth of bool
      /// If true, the select field will be disabled. (defaults to: 'false')
    | Disabled of bool
      /// Override the inline-styles of the error element.
    | ErrorStyle of CSSProp list
      /// The error content to display.
    | ErrorText of React.ReactElement
      /// If true, the floating label will float even when no value is selected.
    | FloatingLabelFixed of bool
      /// Override the inline-styles of the floating label.
    | FloatingLabelStyle of CSSProp list
      /// The content of the floating label.
    | FloatingLabelText of React.ReactElement
      /// If true, the select field will take up the full width of its container. (defaults to: 'false')
    | FullWidth of bool
      /// Override the inline-styles of the hint element.
    | HintStyle of CSSProp list
      /// The hint content to display.
    | HintText of React.ReactElement
      /// Override the inline-styles of the icon element.
    | IconStyle of CSSProp list
      /// Override the label style when the select field is inactive.
    | LabelStyle of CSSProp list
      /// Override the inline-styles of the underlying List element.
    | ListStyle of CSSProp list
      /// Override the default max-height of the underlying DropDownMenu element.
    | MaxHeight of int
      /// Override the inline-styles of the underlying DropDownMenu element.
    | MenuStyle of CSSProp list
      /// Callback function fired when a menu item is selected. Signature: function(event: object, key: number, payload: any) => void event: TouchTap event targeting the menu item that was selected. key: The index of the selected menu item. payload: The value prop of the selected menu item.
    // | OnChange of ((obj*int*obj)->unit)
    | OnChange of  System.Func<React.SyntheticEvent,int,'value,unit>
      /// Override the inline-styles of the underline element when the select field is disabled.
    | UnderlineDisabledStyle of CSSProp list
      /// Override the inline-styles of the underline element when the select field is focused.
    | UnderlineFocusStyle of CSSProp list
      /// Override the inline-styles of the underline element.
    | UnderlineStyle of CSSProp list
      /// The value that is currently selected.
    | Value of obj
    interface ISelectFieldProp

  let inline SelectListStyle style = !!("listStyle", style |> wrapProps)

  /// A slider is an interface for users to input a value in a range. Sliders can be continuous or discrete and can be enabled or disabled.
  type ISliderProp = interface end
  type SliderProp =
      /// The axis on which the slider will slide. (defaults to: 'PropTypes.Axis.X')
    | Axis of PropTypes.Axis
      /// The default value of the slider.
    | DefaultValue of decimal
      /// Deprecated. Use a sibling node element instead. It will be removed with v0.17.0. Describe the slider.
    | Description of (React.ReactElement)
      /// Disables focus ripple if set to true. (defaults to: 'false')
    | DisableFocusRipple of bool
      /// If true, the slider will not be interactable. (defaults to: 'false')
    | Disabled of bool
      /// Deprecated. Use a sibling node element instead. It will be removed with v0.17.0. An error message for the slider.
    | Error of (React.ReactElement)
      /// The maximum value the slider can slide to on a scale from 0 to 1 inclusive. Cannot be equal to min. (defaults to: '1')
    | Max of decimal
      /// The minimum value the slider can slide to on a scale from 0 to 1 inclusive. Cannot be equal to max. (defaults to: '0')
    | Min of decimal
      /// The name of the slider. Behaves like the name attribute of an input element.
    | Name of (string)
      /// Callback function that is fired when the user changes the slider's value.
    | OnChange of System.Func<React.SyntheticEvent,float,unit>
      /// Callback function that is fired when the slider has begun to move.
    | OnDragStart of (React.SyntheticEvent->unit)
      /// Callback function that is fired when the slide has stopped moving.
    | OnDragStop of (React.SyntheticEvent->unit)
      /// Whether or not the slider is required in a form. (defaults to: 'true')
    | Required of bool
      /// Override the inline-styles of the inner slider element.
    | SliderStyle of CSSProp list
      /// The granularity the slider can step through values. (defaults to: '0.01')
    | Step of decimal
      /// The value of the slider.
    | Value of decimal
    interface ISliderProp


  /// A checkbox is used to verify which options you want selected from a group.
  type ICheckboxProp = interface end
  type CheckboxProp =
      /// Checkbox is checked if true.
    | Checked of bool
      /// The SvgIcon to use for the checked state. This is useful to create icon toggles.
    | CheckedIcon of React.ReactElement
      /// The default state of our checkbox component. Warning: This cannot be used in conjunction with checked. Decide between using a controlled or uncontrolled input element and remove one of these props. More info: https://fb.me/react-controlled-components
    | DefaultChecked of bool
      /// Disabled if true. (defaults to: 'false')
    | Disabled of bool
      /// Overrides the inline-styles of the icon element.
    | IconStyle of CSSProp list
      /// Overrides the inline-styles of the input element.
    | InputStyle of CSSProp list
      /// Where the label will be placed next to the checkbox. (defaults to: 'PropTypes.LeftRight.Right')
    | LabelPosition of PropTypes.LeftRight
      /// Overrides the inline-styles of the Checkbox element label.
    | LabelStyle of CSSProp list
      /// Callback function that is fired when the checkbox is checked. Signature: function(event: object, isInputChecked: boolean) => void event:change event targeting the underlying checkbox input. isInputChecked: The checked value of the underlying checkbox input.
    | OnCheck of System.Func<obj,bool,unit>
      /// The SvgIcon to use for the unchecked state. This is useful to create icon toggles.
    | UncheckedIcon of React.ReactElement
      /// ValueLink for when using controlled checkbox.
    | ValueLink of obj
    interface ICheckboxProp


  /// A toggle switch is used as an on/off control.
  type IToggleProp = interface end
  type ToggleProp =
      /// Determines whether the Toggle is initially turned on. Warning: This cannot be used in conjunction with toggled. Decide between using a controlled or uncontrolled input element and remove one of these props. More info: https://fb.me/react-controlled-components (defaults to: 'false')
    | DefaultToggled of bool
      /// Will disable the toggle if true. (defaults to: 'false')
    | Disabled of bool
      /// Overrides the inline-styles of the Toggle element.
    | ElementStyle of CSSProp list
      /// Overrides the inline-styles of the Icon element.
    | IconStyle of CSSProp list
      /// Overrides the inline-styles of the input element.
    | InputStyle of CSSProp list
      /// Label for toggle.
    | Label of React.ReactElement
      /// Where the label will be placed next to the toggle. (defaults to: 'PropTypes.LeftRight.Left')
    | LabelPosition of PropTypes.LeftRight
      /// Overrides the inline-styles of the Toggle element label.
    | LabelStyle of CSSProp list
      /// Callback function that is fired when the toggle switch is toggled.
    | OnToggle of (unit->unit)
      /// Override style of ripple.
    | RippleStyle of CSSProp list
      /// Override style for thumb.
    | ThumbStyle of CSSProp list
      /// Override the inline styles for thumb when the toggle switch is toggled on.
    | ThumbSwitchedStyle of CSSProp list
      /// Toggled if set to true.
    | Toggled of bool
      /// Override style for track.
    | TrackStyle of CSSProp list
      /// Override the inline styles for track when the toggle switch is toggled on.
    | TrackSwitchedStyle of CSSProp list
      /// ValueLink prop for when using controlled toggle.
    | ValueLink of obj
    interface IToggleProp



  /// A time picker is used to input a time by displaying an interface the user can interact with.
  type ITimePickerProp = interface end
  type TimePickerProp =
      /// If true, automatically accept and close the picker on set minutes. (defaults to: 'false')
    | AutoOk of bool
      /// Override the label of the 'Cancel' button. (defaults to: '(unbox 'Cancel')')
    | CancelLabel of React.ReactElement
      /// The initial time value of the TimePicker. (defaults to: 'null')
    | DefaultTime of obj
      /// Override the inline-styles of TimePickerDialog's body element.
    | DialogBodyStyle of CSSProp list
      /// Override the inline-styles of TimePickerDialog's root element.
    | DialogStyle of CSSProp list
      /// If true, the TimePicker is disabled. (defaults to: 'false')
    | Disabled of bool
      /// Tells the component to display the picker in ampm (12hr) format or 24hr format. (defaults to: ''24hr'')
    | Format of string
      ///
    | HintText of string
      /// Override the label of the 'OK' button. (defaults to: '(unbox 'OK')')
    | OkLabel of React.ReactElement
      /// Callback function that is fired when the time value changes. The time value is passed in a Date Object. Since there is no particular event associated with the change the first argument will always be null and the second argument will be the new Date instance.
    | OnChange of System.Func<React.SyntheticEvent,DateTime,unit>
      /// Callback function fired when the TimePicker dialog is dismissed.
    | OnDismiss of (unit->unit)
      /// Callback function fired when the TimePicker TextField gains focus.
    | OnFocus of (unit->unit)
      /// Callback function fired when the TimePicker dialog is shown.
    | OnShow of (unit->unit)
      /// If true, uses ('noon' / 'midnight') instead of ('12 a.m.' / '12 p.m.'). It's technically more correct to refer to '12 noon' and '12 midnight' rather than '12 a.m.' and '12 p.m.' and it avoids confusion between different locales. By default (for compatibility reasons) TimePicker uses ('12 a.m.' / '12 p.m.'). (defaults to: 'false')
    | Pedantic of bool
      /// Override the inline-styles of TimePicker's TextField element.
    | TextFieldStyle of CSSProp list
      /// Sets the time for the Time Picker programmatically. (defaults to: 'null')
    | Value of DateTime
    interface ITimePickerProp



  /// Text fields allow users to input text.
  type ITextFieldProp = interface end
  type TextFieldProp =
      /// The text string to use for the default value.
    | DefaultValue of string
      /// Disables the text field if set to true. (defaults to: 'false')
    | Disabled of bool
      /// The style object to use to override error styles.
    | ErrorStyle of CSSProp list
      /// The error content to display.
    | ErrorText of React.ReactElement
      /// If true, the floating label will float even when there is no value. (defaults to: 'false')
    | FloatingLabelFixed of bool
      /// The style object to use to override floating label styles when focused.
    | FloatingLabelFocusStyle of CSSProp list
      /// The style object to use to override floating label styles when shrunk.
    | FloatingLabelShrinkStyle of CSSProp list
      /// The style object to use to override floating label styles.
    | FloatingLabelStyle of CSSProp list
      /// The content to use for the floating label element.
    | FloatingLabelText of React.ReactElement
      /// If true, the field receives the property width 100%. (defaults to: 'false')
    | FullWidth of bool
      /// Override the inline-styles of the TextField's hint text element.
    | HintStyle of CSSProp list
      /// The hint content to display.
    | HintText of React.ReactElement
      /// Override the inline-styles of the TextField's input element. When multiLine is false: define the style of the input element. When multiLine is true: define the style of the container of the textarea.
    | InputStyle of CSSProp list
      /// If true, a textarea element will be rendered. The textarea also grows and shrinks according to the number of lines. (defaults to: 'false')
    | MultiLine of bool
      /// Name applied to the input.
    | Name of string
      /// Callback function that is fired when the textfield's value changes.
    | OnChange of System.Func<React.SyntheticEvent,string,unit>
      /// Number of rows to display when multiLine is set to true. (defaults to: '1')
    | Rows of int
      /// Maximum number of rows to display when multiLine is set to true.
    | RowsMax of int
      /// Override the inline-styles of the TextField's textarea element. The TextField use either a textarea or an input, this property has effects only when multiLine is true.
    | TextareaStyle of CSSProp list
      /// Specifies the type of input to display such as 'password' or 'text'. (defaults to: ''text'')
    | Type of string
      /// Override the inline-styles of the TextField's underline element when disabled.
    | UnderlineDisabledStyle of CSSProp list
      /// Override the inline-styles of the TextField's underline element when focussed.
    | UnderlineFocusStyle of CSSProp list
      /// If true, shows the underline for the text field. (defaults to: 'true')
    | UnderlineShow of bool
      /// Override the inline-styles of the TextField's underline element.
    | UnderlineStyle of CSSProp list
      /// The value of the text field.
    | Value of string

    | MaxLength of int
    interface ITextFieldProp
    interface ITimePickerProp
    interface IDatePickerProp

  let inline TextFieldInputStyle style = !!("inputStyle", style |> wrapProps)


  /// Radio buttons are switches used for selection from multiple options.
  type IRadioButtonProp = interface end
  type RadioButtonProp =
      /// The icon element to show when the radio button is checked.
    | CheckedIcon of React.ReactElement
      /// If true, the radio button is disabled. (defaults to: 'false')
    | Disabled of bool
      /// Override the inline-styles of the icon element.
    | IconStyle of CSSProp list
      /// Override the inline-styles of the input element.
    | InputStyle of CSSProp list
      /// Override the inline-styles of the label element.
    | LabelStyle of CSSProp list
      /// The icon element to show when the radio button is unchecked.
    | UncheckedIcon of React.ReactElement
      /// The value of the radio button.
    | Value of obj
    interface IRadioButtonProp


  /// Radio buttons are switches used for selection from multiple options.
  type IRadioButtonGroupProp = interface end
  type RadioButtonGroupProp =
      /// The value property of the radio button that will be selected by default. This takes precedence over the checked property of the RadioButton elements.
    | DefaultSelected of obj
      /// Where the label will be placed for all child radio buttons. This takes precedence over the labelPosition property of the RadioButton elements.
    | LabelPosition of PropTypes.LeftRight
      /// Callback function that is fired when a radio button has been checked. Signature: function(event: object, value: undefined) => void event:change event targeting the selected radio button. value: The value of the selected radio button.
    | OnChange of ((obj*obj)->unit)
      /// The value of the currently selected radio button.
    | ValueSelected of obj
    interface IRadioButtonGroupProp


  /// The app bar, formerly known as the action bar in Android, is a special kind of toolbar that's used for branding, navigation, search, and actions.
  type IAppBarProp = interface end
  type AppBarProp =
      /// The classname of the icon on the left of the app bar. If you are using a stylesheet for your icons, enter the class name for the icon to be used here.
    | IconClassNameLeft of string
      /// Similiar to the iconClassNameLeft prop except that it applies to the icon displayed on the right of the app bar.
    | IconClassNameRight of string
      /// The custom element to be displayed on the left side of the app bar such as an SvgIcon.
    | IconElementLeft of (React.ReactElement)
      /// Similiar to the iconElementLeft prop except that this element is displayed on the right of the app bar.
    | IconElementRight of (React.ReactElement)
      /// Override the inline-styles of the element displayed on the left side of the app bar.
    | IconStyleLeft of CSSProp list
      /// Override the inline-styles of the element displayed on the right side of the app bar.
    | IconStyleRight of CSSProp list
      /// Callback function for when the left icon is selected via a touch tap. Signature: function(event: object) => void event: TouchTap event targeting the left IconButton.
    | OnLeftIconButtonTouchTap of (React.SyntheticEvent->unit)
      /// Callback function for when the right icon is selected via a touch tap. Signature: function(event: object) => void event: TouchTap event targeting the right IconButton.
    | OnRightIconButtonTouchTap of (React.SyntheticEvent->unit)
      /// Callback function for when the title text is selected via a touch tap. Signature: function(event: object) => void event: TouchTap event targeting the title node.
    | OnTitleTouchTap of (React.SyntheticEvent->unit)
      /// Determines whether or not to display the Menu icon next to the title. Setting this prop to false will hide the icon. (defaults to: 'true')
    | ShowMenuIconButton of bool
      /// The title to display on the app bar. (defaults to: '''')
    | Title of React.ReactElement
      /// Override the inline-styles of the app bar's title element.
    | TitleStyle of CSSProp list
      /// The zDepth of the component. The shadow of the app bar is also dependent on this property. (defaults to: '1')
    | ZDepth of PropTypes.ZDepth
    interface IAppBarProp


  /// Dialogs contain text and UI controls focused on a specific task. They inform users about critical information, require users to make decisions, or involve multiple tasks.
  type IDialogProp = interface end
  type DialogProp =
      /// Action buttons to display below the Dialog content (children). This property accepts either a React element, or an array of React elements.
    | Actions of React.ReactElement
      /// The className to add to the actions container's root element.
    | ActionsContainerClassName of string
      /// Overrides the inline-styles of the actions container's root element.
    | ActionsContainerStyle of CSSProp list
      /// If set to true, the height of the Dialog will be auto detected. A max height will be enforced so that the content does not extend beyond the viewport. (defaults to: 'true')
    | AutoDetectWindowHeight of bool
      /// If set to true, the body content of the Dialog will be scrollable. (defaults to: 'false')
    | AutoScrollBodyContent of bool
      /// The className to add to the content's root element under the title.
    | BodyClassName of string
      /// Overrides the inline-styles of the content's root element under the title.
    | BodyStyle of CSSProp list
      /// The className to add to the content container.
    | ContentClassName of string
      /// Overrides the inline-styles of the content container.
    | ContentStyle of CSSProp list
      /// Force the user to use one of the actions in the Dialog. Clicking outside the Dialog will not trigger the onRequestClose. (defaults to: 'false')
    | Modal of bool
      /// Fired when the Dialog is requested to be closed by a click outside the Dialog or on the buttons. Signature: function(buttonClicked: bool) => void buttonClicked: Determines whether a button click triggered this request.
    | OnRequestClose of (bool->unit)
      /// The className to add to the Overlay component that is rendered behind the Dialog.
    | OverlayClassName of string
      /// Overrides the inline-styles of the Overlay component that is rendered behind the Dialog.
    | OverlayStyle of CSSProp list
      /// Determines whether the Dialog should be repositioned when it's contents are updated. (defaults to: 'true')
    | RepositionOnUpdate of bool
      /// The title to display on the Dialog. Could be number, string, element or an array containing these types.
    | Title of React.ReactElement
      /// The className to add to the title's root container element.
    | TitleClassName of string
      /// Overrides the inline-styles of the title's root container element.
    | TitleStyle of CSSProp list
    interface IDialogProp

  let inline DialogBodyStyle style = !!("bodyStyle", style |> wrapProps)

  /// Dividers group and separate content within lists and page layouts. The divider is a thin rule, lightweight yet sufficient to distinguish content visually and spatially.
  type IDividerProp = interface end
  type DividerProp =
      /// If true, the Divider will be indented. (defaults to: 'false')
    | Inset of bool
    interface IDividerProp


  /// The Drawer slides in from the side. It is a common pattern found in Google apps and follows the keylines and metrics for lists.
  type IDrawerProp = interface end
  type DrawerProp =
      /// The CSS class name of the container element.
    | ContainerClassName of string
      /// Override the inline-styles of the container element.
    | ContainerStyle of CSSProp list
      /// If true, swiping sideways when the Drawer is closed will not open it. (defaults to: 'false')
    | DisableSwipeToOpen of bool
      /// If true, the Drawer will be docked. In this state, the overlay won't show and clicking on a menu item will not close the Drawer. (defaults to: 'true')
    | Docked of bool
      /// Callback function fired when the open state of the Drawer is requested to be changed. Signature: function(open: boolean, reason: string) => void open: If true, the Drawer was requested to be opened. reason: The reason for the open or close request. Possible values are 'swipe' for open requests; 'clickaway' (on overlay clicks), 'escape' (on escape key press), and 'swipe' for close requests.
    | OnRequestChange of ((bool*string)->unit)
      /// If true, the Drawer is opened. Providing a value will turn the Drawer into a controlled component. (defaults to: 'null')
    | Open of bool
      /// If true, the Drawer is positioned to open from the opposite side. (defaults to: 'false')
    | OpenSecondary of bool
      /// The CSS class name to add to the Overlay component that is rendered behind the Drawer.
    | OverlayClassName of string
      /// Override the inline-styles of the Overlay component that is rendered behind the Drawer.
    | OverlayStyle of CSSProp list
      /// The width of the left most (or right most) area in pixels where the Drawer can be swiped open from. Setting this to null spans that area to the entire page (CAUTION! Setting this property to null might cause issues with sliders and swipeable Tabs: use at your own risk). (defaults to: '30')
    | SwipeAreaWidth of int
      /// The width of the Drawer in pixels. Defaults to using the values from theme. (defaults to: 'null')
    | Width of int
      /// The zDepth of the Drawer. (defaults to: '2')
    | ZDepth of PropTypes.ZDepth
    interface IDrawerProp


  /// A Paper element is a basic container that can give depth to the page.
  type IPaperProp = interface end
  type PaperProp =
      /// Set to true to generate a circlular paper container. (defaults to: 'false')
    | Circle of bool
      /// By default, the paper container will have a border radius. Set this to false to generate a container with sharp corners. (defaults to: 'true')
    | Rounded of bool
      /// Set to false to disable CSS transitions for the paper element. (defaults to: 'true')
    | TransitionEnabled of bool
      /// This number represents the zDepth of the paper shadow. (defaults to: '1')
    | ZDepth of PropTypes.ZDepth
    interface IPaperProp


  /// A Popover can be used as an alternative to a Drop Down Menu that can contain elements inside. In our examples we are using a Menu, but any suitable combination of components can be used.
  type IPopoverProp = interface end
  type PopoverProp =
      /// This is the DOM element that will be used to set the position of the popover.
    | AnchorEl of Browser.EventTarget
      /// This is the point on the anchor where the popover's targetOrigin will attach to. Options: vertical: [top, center, bottom] horizontal: [left, middle, right].
    | AnchorOrigin of PropTypes.Origin
      /// If true, the popover will apply transitions when it is added to the DOM.
    | Animated of bool
      /// Override the default animation component used.
    | Animation of (unit->unit)
      /// If true, the popover will hide when the anchor is scrolled off the screen.
    | AutoCloseWhenOffScreen of bool
      /// If true, the popover (potentially) ignores targetOrigin and anchorOrigin to make itself fit on screen, which is useful for mobile devices.
    | CanAutoPosition of bool
      /// Callback function fired when the popover is requested to be closed.
    | OnRequestClose of  (string->unit)
      /// If true, the popover is visible.
    | Open of bool
      /// This is the point on the popover which will attach to the anchor's origin. Options: vertical: [top, center, bottom] horizontal: [left, middle, right].
    | TargetOrigin of PropTypes.Origin
      /// If true, the popover will render on top of an invisible layer, which will prevent clicks to the underlying elements, and trigger an onRequestClose('clickAway') call.
    | UseLayerForClickAway of bool
      /// The zDepth of the popover.
    | ZDepth of PropTypes.ZDepth
    interface IPopoverProp

  /// Circular Progress will rotate to show the progress of a task or that there is a wait for a task to complete.
  type ICircularProgressProp = interface end
  type CircularProgressProp =
      /// Override the progress's color.
    | Color of string
      /// Style for inner wrapper div.
    | InnerStyle of CSSProp list
      /// The max value of progress, only works in determinate mode. (Default to: 100)
    | Max of float
      /// The min value of progress, only works in determinate mode. (Default to: 0)
    | Min of float
      /// The mode of show your progress, indeterminate for when there is no value for progress. (Default to: 'indeterminate')
    | Mode of ProgressMode
      /// The diameter of the progress in pixels. (Default to: 40)
    | Size of int
      /// Stroke width in pixels. (Default to: 3.5)
    | Thickness of float
      /// The value of progress, only works in determinate mode. (Default to: 0)
    | Value of float
    interface ICircularProgressProp


  /// The refresh indicator is used when showing an item is loading. It is kept hidden from the interface until it's status prop is changed to loading or ready.
  type IRefreshIndicatorProp = interface end
  type RefreshIndicatorProp =
    /// Override the theme's color of the indicator while it's status is "ready" and it's percentage is less than 100.
    | Color of string
    /// Override the theme's color of the indicator while it's status is "loading" or when it's percentage is 100.
    | LoadingColor of string
    /// The confirmation progress to fetch data. Max value is 100.
    | Percentage of float
    /// Size in pixels.
    | Size of float
    /// The display status of the indicator. If the status is "ready", the indicator will display the ready state arrow. If the status is "loading", it will display the loading progress indicator. If the status is "hide", the indicator will be hidden.
    | Status of RefreshIndicatorStatus
    interface IRefreshIndicatorProp

  /// The bottom navigation is a special kind of toolbar that's used for navigation.
  type IBottomNavigationProp = interface end
  type BottomNavigationProp =
      /// The index of the currently selected navigation item.
    | SelectedIndex of int
    interface IBottomNavigationProp


  /// The bottom navigation is a special kind of toolbar that's used for navigation.
  type IBottomNavigationItemProp = interface end
  type BottomNavigationItemProp =
      /// Set the icon representing the view for this item.
    | Icon of React.ReactElement
      /// Set the label describing the view for this item.
    | Label of React.ReactElement
    interface IBottomNavigationItemProp


  /// Tabs make it easy to explore and switch between different views or functional aspects of an app or to browse categorized data sets.
  type ITabsProp = interface end
  type TabsProp =
      /// The css class name of the content's container.
    | ContentContainerClassName of string
      /// Override the inline-styles of the content's container.
    | ContentContainerStyle of CSSProp list
      /// Specify initial visible tab index. If initialSelectedIndex is set but larger than the total amount of specified tabs, initialSelectedIndex will revert back to default. If initialSlectedIndex is set to any negative value, no tab will be selected intially. (defaults to: '0')
    | InitialSelectedIndex of int
      /// Override the inline-styles of the InkBar.
    | InkBarStyle of CSSProp list
      /// Called when the selected value change. (defaults to: '(fun _ -> ())')
    | OnChange of (unit->unit)
      /// Override the inline-styles of the tab-labels container.
    | TabItemContainerStyle of CSSProp list
      /// Override the default tab template used to wrap the content of each tab element.
    | TabTemplate of (unit->unit)
      /// Override the inline-styles of the tab template.
    | TabTemplateStyle of CSSProp list
      /// Makes Tabs controllable and selects the tab whose value prop matches this prop.
    | Value of obj
    interface ITabsProp


  /// Tabs make it easy to explore and switch between different views or functional aspects of an app or to browse categorized data sets.
  type ITabProp = interface end
  type TabProp =
      /// Sets the icon of the tab, you can pass FontIcon or SvgIcon elements.
    | Icon of React.ReactElement
      /// Sets the text value of the tab item to the string specified.
    | Label of React.ReactElement
      /// Fired when the active tab changes by touch or tap. Use this event to specify any functionality when an active tab changes. For example - we are using this to route to home when the third tab becomes active. This function will always recieve the active tab as its first argument.
    | OnActive of (unit->unit)
      /// If value prop passed to Tabs component, this value prop is also required. It assigns a value to the tab so that it can be selected by the Tabs.
    | Value of obj
    interface ITabProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardProp = interface end
  type CardProp =
      /// Override the inline-styles of the container element.
    | ContainerStyle of CSSProp list
      /// If true, this card component is expandable. Can be set on any child of the Card component. (defaults to: 'false')
    | Expandable of bool
      /// Whether this card is expanded. If true or false the component is controlled. if null the component is uncontrolled. (defaults to: 'null')
    | Expanded of bool
      /// Whether this card is initially expanded. (defaults to: 'false')
    | InitiallyExpanded of bool
      /// Callback function fired when the expandable state of the card has changed. Signature: function(newExpandedState: boolean) => void newExpandedState: Represents the new expanded state of the card.
    | OnExpandChange of (unit->unit)
      /// If true, this card component will include a button to expand the card. CardTitle, CardHeader and CardActions implement showExpandableButton. Any child component of Card can implements showExpandableButton or forwards the property to a child component supporting it.
    | ShowExpandableButton of bool
    interface ICardProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardActionsProp = interface end
  type CardActionsProp =
      /// If true, a click on this card component expands the card.
    | ActAsExpander of bool
      /// If true, this card component is expandable.
    | Expandable of bool
      /// If true, this card component will include a button to expand the card.
    | ShowExpandableButton of bool
    interface ICardActionsProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardHeaderProp = interface end
  type CardHeaderProp =
      /// If true, a click on this card component expands the card.
    | ActAsExpander of bool
      /// This is the Avatar element to be displayed on the Card Header. If avatar is an Avatar or other element, it will be rendered. If avatar is a string, it will be used as the image src for an Avatar. (defaults to: 'null')
    | Avatar of React.ReactElement
      /// Can be used to pass a closeIcon if you don't like the default expandable close Icon.
    | CloseIcon of React.ReactElement
      /// If true, this card component is expandable.
    | Expandable of bool
      /// Can be used to pass a openIcon if you don't like the default expandable open Icon.
    | OpenIcon of React.ReactElement
      /// If true, this card component will include a button to expand the card.
    | ShowExpandableButton of bool
      /// Can be used to render a subtitle in Card Header.
    | Subtitle of React.ReactElement
      /// Override the subtitle color.
    | SubtitleColor of string
      /// Override the inline-styles of the subtitle.
    | SubtitleStyle of CSSProp list
      /// Override the inline-styles of the text.
    | TextStyle of CSSProp list
      /// Can be used to render a title in Card Header.
    | Title of React.ReactElement
      /// Override the title color.
    | TitleColor of string
      /// Override the inline-styles of the title.
    | TitleStyle of CSSProp list
    interface ICardHeaderProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardMediaProp = interface end
  type CardMediaProp =
      /// If true, a click on this card component expands the card.
    | ActAsExpander of bool
      /// If true, this card component is expandable.
    | Expandable of bool
      /// Override the inline-styles of the Card Media.
    | MediaStyle of CSSProp list
      /// Can be used to render overlay element in Card Media.
    | Overlay of React.ReactElement
      /// Override the inline-styles of the overlay container.
    | OverlayContainerStyle of CSSProp list
      /// Override the inline-styles of the overlay content.
    | OverlayContentStyle of CSSProp list
      /// Override the inline-styles of the overlay element.
    | OverlayStyle of CSSProp list
    interface ICardMediaProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardTextProp = interface end
  type CardTextProp =
      /// If true, a click on this card component expands the card.
    | ActAsExpander of bool
      /// Override the CardText color.
    | Color of PropTypes.Color
      /// If true, this card component is expandable.
    | Expandable of bool
    interface ICardTextProp


  /// A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
  type ICardTitleProp = interface end
  type CardTitleProp =
      /// If true, a click on this card component expands the card.
    | ActAsExpander of bool
      /// If true, this card component is expandable.
    | Expandable of bool
      /// If true, this card component will include a button to expand the card.
    | ShowExpandableButton of bool
      /// Can be used to render a subtitle in the Card Title.
    | Subtitle of React.ReactElement
      /// Override the subtitle color.
    | SubtitleColor of PropTypes.Color
      /// Override the inline-styles of the subtitle.
    | SubtitleStyle of CSSProp list
      /// Can be used to render a title in the Card Title.
    | Title of React.ReactElement
      /// Override the title color.
    | TitleColor of PropTypes.Color
      /// Override the inline-styles of the title.
    | TitleStyle of CSSProp list
    interface ICardTitleProp


  /// Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
  type IToolbarProp = interface end
  type ToolbarProp =
      /// Do not apply desktopGutter to the Toolbar. (defaults to: 'falseish')
    | NoGutter of bool
    interface IToolbarProp


  /// Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
  type IToolbarGroupProp = interface end
  type ToolbarGroupProp =
      /// Set this to true for if the ToolbarGroup is the first child of Toolbar to prevent setting the left gap. (defaults to: 'false')
    | FirstChild of bool
      /// Set this to true for if the ToolbarGroup is the last child of Toolbar to prevent setting the right gap. (defaults to: 'false')
    | LastChild of bool
    interface IToolbarGroupProp


  /// Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
  type IToolbarSeparatorProp = interface end


  /// Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
  type IToolbarTitleProp = interface end
  type ToolbarTitleProp =
      /// The text to be displayed.
    | Text of string
    interface IToolbarTitleProp


  /// A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step). Children should be two or more <Step /> components
  type IStepperProp = interface end
  type StepperProp =
      /// Set the active step (zero based index). This will enable Step control helpers.
    | ActiveStep of int
      /// If set to true, the Stepper will assist in controlling steps for linear flow (defaults to: 'true')
    | Linear of bool
      /// The stepper orientation (layout flow direction) (defaults to: 'PropTypes.Orientation.Horizontal')
    | Orientation of PropTypes.Orientation
    interface IStepperProp


  /// A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
  type IStepProp = interface end
  type StepProp =
      /// Sets the step as active. Is passed to child components.
    | Active of bool
      /// Mark the step as completed. Is passed to child components.
    | Completed of bool
      /// Mark the step as disabled, will also disable the button if StepButton is a child of Step. Is passed to child components.
    | Disabled of bool
    interface IStepProp


  /// A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
  type IStepLabelProp = interface end
  type StepLabelProp =
      /// Sets active styling. Overrides disabled coloring.
    | Active of bool
      /// Sets completed styling. Overrides disabled coloring.
    | Completed of bool
      /// Sets disabled styling.
    | Disabled of bool
      /// The icon displayed by the step label.
    | Icon of React.ReactElement option
      /// Override the inline-styles of the icon container element.
    | IconContainerStyle of CSSProp list
    interface IStepLabelProp


  /// A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
  type IStepButtonProp = interface end
  type StepButtonProp =
      /// Passed from Step Is passed to StepLabel.
    | Active of bool
      /// Sets completed styling. Is passed to StepLabel.
    | Completed of bool
      /// Disables the button and sets disabled styling. Is passed to StepLabel.
    | Disabled of bool
      /// The icon displayed by the step label.
    | Icon of React.ReactElement
      /// Override the inline-styles of the icon container element.
    | IconContainerStyle of CSSProp list
    interface IStepButtonProp


  /// A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
  type IStepContentProp = interface end
  type StepContentProp =
      /// Expands the content
    | Active of bool
      /// ReactTransitionGroup component. (defaults to: '(props) => { }')
    | Transition of (obj->unit)
      /// Adjust the duration of the content expand transition. Passed as a prop to the transition component. (defaults to: '450')
    | TransitionDuration of int
    interface IStepContentProp


  /// Tables are used to display data and to organize it.
  type ITableProp = interface end
  type TableProp =
      /// Set to true to indicate that all rows should be selected. (defaults to: 'false')
    | AllRowsSelected of bool
      /// Override the inline-styles of the body's table element.
    | BodyStyle of CSSProp list
      /// If true, the footer will appear fixed below the table. The default value is true. (defaults to: 'true')
    | FixedFooter of bool
      /// If true, the header will appear fixed above the table. The default value is true. (defaults to: 'true')
    | FixedHeader of bool
      /// Override the inline-styles of the footer's table element.
    | FooterStyle of CSSProp list
      /// Override the inline-styles of the header's table element.
    | HeaderStyle of CSSProp list
      /// The height of the table. (defaults to: ''inherit'')
    | Height of string
      /// If true, multiple table rows can be selected. CTRL/CMD+Click and SHIFT+Click are valid actions. The default value is false. (defaults to: 'false')
    | MultiSelectable of bool
      /// Called when a row cell is clicked. rowNumber is the row number and columnId is the column number or the column key.
    | OnCellClick of (unit->unit)
      /// Called when a table cell is hovered. rowNumber is the row number of the hovered row and columnId is the column number or the column key of the cell.
    | OnCellHover of (unit->unit)
      /// Called when a table cell is no longer hovered. rowNumber is the row number of the row and columnId is the column number or the column key of the cell.
    | OnCellHoverExit of (unit->unit)
      /// Called when a table row is hovered. rowNumber is the row number of the hovered row.
    | OnRowHover of (unit->unit)
      /// Called when a table row is no longer hovered. rowNumber is the row number of the row that is no longer hovered.
    | OnRowHoverExit of (unit->unit)
      /// Called when a row is selected. selectedRows is an array of all row selections. IF all rows have been selected, the string 'all' will be returned instead to indicate that all rows have been selected.
    | OnRowSelection of (System.Func<int array,unit>)
      /// If true, table rows can be selected. If multiple row selection is desired, enable multiSelectable. The default value is true. (defaults to: 'true')
    | Selectable of bool
      /// Override the inline-styles of the table's wrapper element.
    | WrapperStyle of CSSProp list
    interface ITableProp


  /// Tables are used to display data and to organize it.
  type ITableRowProp = interface end
  type TableRowProp =
      /// If true, row border will be displayed for the row. If false, no border will be drawn. (defaults to: 'trueish')
    | DisplayBorder of bool
      /// Controls whether or not the row reponseds to hover events. (defaults to: 'false')
    | Hoverable of bool
      /// Controls whether or not the row should be rendered as being hovered. This property is evaluated in addition to this.state.hovered and can be used to synchronize the hovered state with some other external events. (defaults to: 'false')
    | Hovered of bool
      /// Number to identify the row. This property is automatically populated when used with the TableBody component.
    | RowNumber of int
      /// If true, table rows can be selected. If multiple row selection is desired, enable multiSelectable. The default value is true. (defaults to: 'true')
    | Selectable of bool
      /// Indicates that a particular row is selected. This property can be used to programmatically select rows. (defaults to: 'false')
    | Selected of bool
      /// Indicates whether or not the row is striped. (defaults to: 'false')
    | Striped of bool
    interface ITableRowProp


  /// Tables are used to display data and to organize it.
  type ITableRowColumnProp = interface end


  /// Tables are used to display data and to organize it.
  type ITableHeaderProp = interface end
  type TableHeaderProp =
      /// Controls whether or not header rows should be adjusted for a checkbox column. If the select all checkbox is true, this property will not influence the number of columns. This is mainly useful for 'super header' rows so that the checkbox column does not create an offset that needs to be accounted for manually. (defaults to: 'true')
    | AdjustForCheckbox of bool
      /// Controls whether or not the select all checkbox is displayed. (defaults to: 'true')
    | DisplaySelectAll of bool
      /// If set to true, the select all button will be interactable. If set to false, the button will not be interactable. To hide the checkbox, set displaySelectAll to false. (defaults to: 'true')
    | EnableSelectAll of bool
    interface ITableHeaderProp


  /// Tables are used to display data and to organize it.
  type ITableHeaderColumnProp = interface end
  type TableHeaderColumnProp =
      /// Number to identify the header row. This property is automatically populated when used with TableHeader.
    | ColumnNumber of int
      /// The string to supply to the tooltip. If not string is supplied no tooltip will be shown.
    | Tooltip of string
      /// Additional styling that can be applied to the tooltip.
    | TooltipStyle of CSSProp list
    interface ITableHeaderColumnProp


  /// Tables are used to display data and to organize it.
  type ITableBodyProp = interface end
  type TableBodyProp =
      /// Controls whether or not to deselect all selected rows after clicking outside the table. (defaults to: 'true')
    | DeselectOnClickaway of bool
      /// Controls the display of the row checkbox. The default value is true. (defaults to: 'true')
    | DisplayRowCheckbox of bool
      /// Controls whether or not the rows are pre-scanned to determine initial state. If your table has a large number of rows and you are experiencing a delay in rendering, turn off this property. (defaults to: 'true')
    | PreScanRows of bool
      /// If true, table rows will be highlighted when the cursor is hovering over the row. The default value is false.
    | ShowRowHover of bool
      /// If true, every other table row starting with the first row will be striped. The default value is false.
    | StripedRows of bool
    interface ITableBodyProp


  /// Tables are used to display data and to organize it.
  type ITableFooterProp = interface end


/////////////////////////////////////////////////
/////////////////////////////////////////////////


  type HTMLProps =
      /// Unique Identifier of React Element
    | Key of string
      /// Callback Function that is fired when the Instance of the React Element is available
    | Ref of (Browser.Element->unit)
      /// Unique Identifier of the HTML DOM Element
    | Id of string
      /// CSS Class
    | ClassName of string
      /// Inline-Style
    | Style of CSSProp list
      /// Callback Function that is fired when the DOM Element is clicked
    | OnClick of (React.MouseEvent->unit)
      /// Callback Function that is fired when the DOM Element is touch tapped or clicked
    | OnTouchTap of (React.SyntheticEvent->unit)
      /// Callback Function that is fired when specific key is pressed down
    | OnKeyDown of (React.KeyboardEvent->unit)
      /// Callback Function that is fired when the DOM Element loses focus
    | OnBlur of (React.FocusEvent->unit)
    interface IAvatarProp
    interface IBadgeProp
    interface IChipProp
    interface IFontIconProp
    interface ISVGIconProp
    interface IIconMenuProp
    interface IDropDownMenuProp
    interface ISnackbarProp
    interface ISubheaderProp
    interface IListProp
    interface IListItemProp
    interface IMenuProp
    interface IMenuItemProp
    interface IFlatButtonProp
    interface IRaisedButtonProp
    interface IFloatingActionButtonProp
    interface IIconButtonProp
    interface IAutoCompleteProp
    interface IDatePickerProp
    interface IDatePickerDialogProp
    interface ISelectFieldProp
    interface ISliderProp
    interface ICheckboxProp
    interface IToggleProp
    interface ITextFieldProp
    interface ITimePickerProp
    interface IRadioButtonProp
    interface IRadioButtonGroupProp
    interface IAppBarProp
    interface IDialogProp
    interface IDividerProp
    interface IDrawerProp
    interface IPaperProp
    interface IPopoverProp
    interface ICircularProgressProp
    interface IRefreshIndicatorProp
    interface IBottomNavigationProp
    interface IBottomNavigationItemProp
    interface ITabsProp
    interface ITabProp
    interface ICardProp
    interface ICardActionsProp
    interface ICardHeaderProp
    interface ICardMediaProp
    interface ICardTextProp
    interface ICardTitleProp
    interface IToolbarProp
    interface IToolbarGroupProp
    interface IToolbarSeparatorProp
    interface IToolbarTitleProp
    interface IStepperProp
    interface IStepProp
    interface IStepLabelProp
    interface IStepButtonProp
    interface IStepContentProp
    interface ITableProp
    interface ITableRowProp
    interface ITableRowColumnProp
    interface ITableHeaderProp
    interface ITableHeaderColumnProp
    interface ITableBodyProp
    interface ITableFooterProp

  let inline Style style = !!("style", style |> wrapProps)

/////////////////////////////////////////////////
/////////////////////////////////////////////////


open Props

/// <summary>Avatars can be used to represent people or object.
/// </summary>
let avatar
  (props:IAvatarProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Avatar (props |> wrapProps) children


/// <summary>This component generates a small badge to the top-right of its child(ren).
/// <para>  --  badgeContent (React.ReactElement) - This is the content rendered within the badge.</para>
/// </summary>
let badge
  (badgeContent:React.ReactElement)
  (props:IBadgeProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "badgeContent" ==> badgeContent ], props |> wrapProps)
  R.from Raw.Badge props children


/// <summary>Chips represent complex entities in small blocks, such as a contact.
/// </summary>
let chip
  (props:IChipProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Chip (props |> wrapProps) children


/// <summary>This component will render any icon defined in any stylesheet included in your project. You can use sites like IcoMoon to generate custom font files, or use prebuilt fonts such as Material icons or Font Awesome either included in your project, or served from a public Content Delivery Network.
/// </summary>
let fonticon
  (props:IFontIconProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.FontIcon (props |> wrapProps) children


/// <summary>The SvgIcon component takes an SVG path element as its child, and converts it to a React component which displays the path and allows the icon to be styled and respond to mouse events.
/// </summary>
let svgicon
  (props:ISVGIconProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.SvgIcon (props |> wrapProps) children


/// <summary>Icon Menus are menus that open from icons. They can give options related to the icon and use a minimal space.
/// <para>  --  iconButtonElement (React.ReactElement) - This is the IconButton to render. This button will open the menu.</para>
/// </summary>
let iconmenu
  (iconButtonElement:React.ReactElement)
  (props:IIconMenuProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "iconButtonElement" ==> iconButtonElement ], props |> wrapProps)
  R.from Raw.IconMenu props children


/// <summary>The DropDownMenu component is Material-UI's implementation of the Textfield dropdown.
/// </summary>
let dropdownmenu
  (props:IDropDownMenuProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.DropDownMenu (props |> wrapProps) children


/// <summary>Snackbars provide lightweight feedback about an operation by showing a brief message at the bottom of the screen. Snackbars can contain an action.
/// <para>  --  message (React.ReactElement) - The message to be displayed. (Note: If the message is an element or array, and the Snackbar may re-render while it is still open, ensure that the same object remains as the message property if you want to avoid the Snackbar hiding and showing again)</para>
/// <para>  --  open (bool) - Controls whether the Snackbar is opened or not.</para>
/// </summary>
let snackbar
  (message:React.ReactElement)
  (``open``:bool)
  (props:ISnackbarProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "message" ==> message ; "open" ==> ``open`` ], props |> wrapProps)
  R.from Raw.Snackbar props children


/// <summary>Subheaders are special list tiles that delineate distinct sections of a list or grid list and are typically related to the current filtering or sorting criteria.
/// </summary>
let subheader
  (props:ISubheaderProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Subheader (props |> wrapProps) children


/// <summary>Lists are used to present multiple items vertically as a single continuous element. They can be configured for many uses such as a contacts list, nested lists, etc.
/// </summary>
let list
  (props:IListProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.List (props |> wrapProps) children


/// <summary>Lists are used to present multiple items vertically as a single continuous element. They can be configured for many uses such as a contacts list, nested lists, etc.
/// </summary>
let listitem
  (props:IListItemProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.ListItem (props |> wrapProps) children


/// <summary>Menus allow you to take an action by selecting from a list revealed upon opening a temporary, new sheet of material.
/// </summary>
let menu
  (props:IMenuProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Menu (props |> wrapProps) children


/// <summary>Menus allow you to take an action by selecting from a list revealed upon opening a temporary, new sheet of material.
/// </summary>
let menuitem
  (props:IMenuItemProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.MenuItem (props |> wrapProps) children

let muiThemeProvider
  (children:React.ReactElement)
  =
  R.from Raw.MuiThemeProvider (createObj [ "theme" ==> (Raw.getMuiTheme.Invoke()) ]) [children]


// MUI-Buttons ----
/// <summary>Flat Buttons are used for general functions and reduce the amount of layering on the screen, making it more readable.
/// </summary>
let flatbutton
  (props:IFlatButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.FlatButton (props |> wrapProps) children


/// <summary>This button is used to add dimension to mostly flat layouts and emphasizes important functions on your page.
/// </summary>
let raisedbutton
  (props:IRaisedButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.RaisedButton (props |> wrapProps) children


/// <summary>The Floating Action Button is used for frequently used functions.
/// </summary>
let floatingactionbutton
  (props:IFloatingActionButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.FloatingActionButton (props |> wrapProps) children


/// <summary>An Icon Button generates a button element around an icon. Also, focus styles will happen on tab but not on click. There are three ways to add an icon:
/// </summary>
let iconbutton
  (props:IIconButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.IconButton (props |> wrapProps) children


// MUI-Forms ----

/// <summary>The auto-complete is an extension of a regular text-field that will auto-complete the input dynamically. It can take different auto-complete filters and uses a menu to display suggestions.
/// <para>  --  dataSource (PropTypes.DataSource) - Array of strings (DataSource.Strings) or nodes (DataSource.Elements) used to populate the list.</para>
/// </summary>
let autocomplete
  (dataSource:PropTypes.DataSource)
  (props:IAutoCompleteProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "dataSource" ==> dataSource ], props |> wrapProps)
  R.from Raw.AutoComplete props children


/// <summary>Date Pickers are used to select a single date for an input.
/// </summary>
let datepicker
  (props:IDatePickerProp list)
  (children:React.ReactElement list)
  =
  let intl = Fable.Core.JsInterop.importDefault<obj> "intl"
  importAll "intl/locale-data/jsonp/de-DE.js" |> ignore
  let props = JS.Object.assign (createObj [ "DateTimeFormat" ==> intl?DateTimeFormat
                                            "locale" ==> "de-DE"
                                            "firstDayOfWeek" ==> 1 ], props |> wrapProps)
  R.from Raw.DatePicker props children


/// <summary>Date Pickers are used to select a single date for an input.
/// </summary>
let datepickerDialog
  (props:IDatePickerDialogProp list)
  (children:React.ReactElement list)
  =
  let intl = Fable.Core.JsInterop.importDefault<obj> "intl"
  importAll "intl/locale-data/jsonp/de-DE.js" |> ignore
  let props = JS.Object.assign (createObj [ "DateTimeFormat" ==> intl?DateTimeFormat
                                            "locale" ==> "de-DE"
                                            "firstDayOfWeek" ==> 1 ], props |> wrapProps)
  R.from Raw.DatePickerDialog props children


/// <summary>To learn more about SelectField please visit the specifications here.
/// </summary>
let selectfield
  (props:ISelectFieldProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.SelectField (props |> wrapProps) children


/// <summary>A slider is an interface for users to input a value in a range. Sliders can be continuous or discrete and can be enabled or disabled.
/// </summary>
let slider
  (props:ISliderProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Slider (props |> wrapProps) children


/// <summary>A checkbox is used to verify which options you want selected from a group.
/// </summary>
let checkbox
  (props:ICheckboxProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Checkbox (props |> wrapProps) children


/// <summary>A toggle switch is used as an on/off control.
/// </summary>
let toggle
  (props:IToggleProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Toggle (props |> wrapProps) children


/// <summary>Text fields allow users to input text.
/// </summary>
let textfield
  (props:ITextFieldProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TextField (props |> wrapProps) children


/// <summary>A time picker is used to input a time by displaying an interface the user can interact with.
/// </summary>
let timepicker
  (props:ITimePickerProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TimePicker (props |> wrapProps) children


/// <summary>Radio buttons are switches used for selection from multiple options.
/// </summary>
let radiobutton
  (props:IRadioButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.RadioButton (props |> wrapProps) children


/// <summary>Radio buttons are switches used for selection from multiple options.
/// <para>  --  name (string) - The name that will be applied to all child radio buttons.</para>
/// </summary>
let radiobuttongroup
  (name:string)
  (props:IRadioButtonGroupProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "name" ==> name ], props |> wrapProps)
  R.from Raw.RadioButtonGroup props children


// MUI-Layout ----

/// <summary>The app bar, formerly known as the action bar in Android, is a special kind of toolbar that's used for branding, navigation, search, and actions.
/// </summary>
let appbar
  (props:IAppBarProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.AppBar (props |> wrapProps) children


/// <summary>Dialogs contain text and UI controls focused on a specific task. They inform users about critical information, require users to make decisions, or involve multiple tasks.
/// <para>  --  open (bool) - Controls whether the Dialog is opened or not.</para>
/// </summary>
let dialog
  (``open``:bool)
  (props:IDialogProp list)
  (children:React.ReactElement list)
  =
  let props = JS.Object.assign (createObj [ "open" ==> ``open`` ], props |> wrapProps)
  R.from Raw.Dialog props children


/// <summary>Dividers group and separate content within lists and page layouts. The divider is a thin rule, lightweight yet sufficient to distinguish content visually and spatially.
/// </summary>
let divider
  (props:IDividerProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Divider (props |> wrapProps) children


/// <summary>The Drawer slides in from the side. It is a common pattern found in Google apps and follows the keylines and metrics for lists.
/// </summary>
let drawer
  (props:IDrawerProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Drawer (props |> wrapProps) children


/// <summary>A Paper element is a basic container that can give depth to the page.
/// </summary>
let paper
  (props:IPaperProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Paper (props |> wrapProps) children


/// <summary>A Paper element is a basic container that can give depth to the page.
/// </summary>
let Popover
  (props:IPopoverProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Popover (props |> wrapProps) children


/// <summary>Circular Progress will rotate to show the progress of a task or that there is a wait for a task to complete.
/// </summary>
let circularProgress
  (props:ICircularProgressProp list)
  =
  R.from Raw.CircularProgress (props |> wrapProps) []


/// <summary>The refresh indicator is used when showing an item is loading. It is kept hidden from the interface until it's status prop is changed to loading or ready.
/// </summary>
let refreshIndicator
  (top : float)
  (left : float)
  (props : IRefreshIndicatorProp list)
  =
  let props = JS.Object.assign (createObj [ "top" ==> top ; "left" ==> left ], props |> wrapProps)
  R.from Raw.RefreshIndicator props []


/// <summary>The bottom navigation is a special kind of toolbar that's used for navigation.
/// </summary>
let bottomnavigation
  (props:IBottomNavigationProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.BottomNavigation (props |> wrapProps) children


/// <summary>The bottom navigation is a special kind of toolbar that's used for navigation.
/// </summary>
let bottomnavigationitem
  (props:IBottomNavigationItemProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.BottomNavigationItem (props |> wrapProps) children


/// <summary>Tabs make it easy to explore and switch between different views or functional aspects of an app or to browse categorized data sets.
/// </summary>
let tabs
  (props:ITabsProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Tabs (props |> wrapProps) children


/// <summary>Tabs make it easy to explore and switch between different views or functional aspects of an app or to browse categorized data sets.
/// </summary>
let tab
  (props:ITabProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Tab (props |> wrapProps) children


// MUI-Layout_Card ----

/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let card
  (props:ICardProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Card (props |> wrapProps) children


/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let cardactions
  (props:ICardActionsProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.CardActions (props |> wrapProps) children


/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let cardheader
  (props:ICardHeaderProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.CardHeader (props |> wrapProps) children


/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let cardmedia
  (props:ICardMediaProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.CardMedia (props |> wrapProps) children


/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let cardtext
  (props:ICardTextProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.CardText (props |> wrapProps) children


/// <summary>A card is a piece of paper with unique related data that serves as an entry point to more detailed information. For example, a card could contain a photo, text, and a link about a single subject.
/// </summary>
let cardtitle
  (props:ICardTitleProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.CardTitle (props |> wrapProps) children


// MUI-Layout_Toolbar ----

/// <summary>Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
/// </summary>
let toolbar
  (props:IToolbarProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Toolbar (props |> wrapProps) children


/// <summary>Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
/// </summary>
let toolbargroup
  (props:IToolbarGroupProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.ToolbarGroup (props |> wrapProps) children


/// <summary>Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
/// </summary>
let toolbarseparator
  (props:IToolbarSeparatorProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.ToolbarSeparator (props |> wrapProps) children


/// <summary>Toolbars are collections of components stacked horizontally against each other. Toolbars provide greater versatility than AppBars which are a subset of toolbars. The following toolbar components can help organize your layout.
/// </summary>
let toolbartitle
  (props:IToolbarTitleProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.ToolbarTitle (props |> wrapProps) children


// MUI-Stepper ----

/// <summary>A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step). Children should be two or more <Step /> components
/// </summary>
let stepper
  (props:IStepperProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Stepper (props |> wrapProps) children


/// <summary>A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
/// </summary>
let step
  (props:IStepProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Step (props |> wrapProps) children


/// <summary>A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
/// </summary>
let steplabel
  (props:IStepLabelProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.StepLabel (props |> wrapProps) children


/// <summary>A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
/// </summary>
let stepbutton
  (props:IStepButtonProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.StepButton (props |> wrapProps) children


/// <summary>A stepper is an interface for users to show numbered steps or for navigation. It just provides views, not handling logic (when the step is active, or when the step is completed, or how to move to the next step).
/// </summary>
let stepcontent
  (props:IStepContentProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.StepContent (props |> wrapProps) children


// MUI-Tables ----

/// <summary>Tables are used to display data and to organize it.
/// </summary>
let table
  (props:ITableProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.Table (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tablerow
  (props:ITableRowProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableRow (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tablerowcolumn
  (props:ITableRowColumnProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableRowColumn (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tableheader
  (props:ITableHeaderProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableHeader (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tableheadercolumn
  (props:ITableHeaderColumnProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableHeaderColumn (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tablebody
  (props:ITableBodyProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableBody (props |> wrapProps) children


/// <summary>Tables are used to display data and to organize it.
/// </summary>
let tablefooter
  (props:ITableFooterProp list)
  (children:React.ReactElement list)
  =
  R.from Raw.TableFooter (props |> wrapProps) children
