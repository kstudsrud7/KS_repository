// App Color Palette
Set(
    gblAppColors,
    {
        // Primary Colors
        Primary1: ColorValue("#30475E"),
        Primary2: ColorValue("#F05454"),
        Primary3: ColorValue("#222831"),
        Primary4: ColorValue("#DDDDDD"),

        
        // Accent Colors
        Black: ColorValue("#000000"),
        Cyan: ColorValue("#17A2B8"),
        Green: ColorValue("#28A745"),
        Orange: ColorValue("#FD7E14"),
        Red: ColorValue("#DC3545"),
        Teal: ColorValue("#20C997"),
        White: ColorValue("#FFFFFF"),
        Yellow: ColorValue("#FFC107"),
        
        // Neutral Colors
        GrayDark: ColorValue("#484644"),
        GrayMediumDark: ColorValue("#8A8886"),
        GrayMedium: ColorValue("#B3b0AD"),
        GrayMediumLight: ColorValue("#D2D0CE"),
        GrayLight: ColorValue("#F3F2F1")
    }
);

// App Fonts & Sizes
Set(
    gblAppFonts,
    {
        Heading: "Roboto, Open Sans",
        Body: "Lato",
        Size: {
            Tiny: 10,
            Regular: 13,
            Subtitle: 16,
            Title: 20,
            Huge: 28
        }
    }
)

// App Icons
Set(
   gblAppIcons,
    {
       // SVG icon code is stored in an ‘Import from Excel’ table named AppIcons
       Checklist: LookUp(AppIcons, Name="Checklist", DataURI),
       Checkmark: LookUp(AppIcons, Name="Checkmark", DataURI)
   }
);

// App Default Control Theme
Set(
    gblAppDefaults,
    {
        BorderColor: gblAppColors.GrayMedium,
        BorderStyle: BorderStyle.None,
        BorderThickness: 2,
        CalendarHeaderFill: ColorFade(gblAppColors.Primary1, -30%),
        CheckboxBorderColor: gblAppColors.GrayMediumDark,
        CheckmarkFill: gblAppColors.Primary2,
        ChevronBackground: gblAppColors.White,
        ChevronDisabledBackground: gblAppColors.GrayLight,
        ChevronDisabledFill: gblAppColors.GrayMedium,
        ChevronFill: gblAppColors.GrayDark,
        ChevronHoverBackground: gblAppColors.GrayMediumLight,
        ChevronHoverFill: gblAppColors.GrayDark,
        Color: gblAppColors.Black,
        DisabledBorderColor: Transparent,
        DisabledColor: gblAppColors.GrayMedium,
        DisabledFill: gblAppColors.GrayLight,
        DisabledSelectionColor: gblAppColors.GrayMedium,
        DisabledSelectionFill: gblAppColors.GrayMedium,
        FalseFill: gblAppColors.GrayMediumDark,
        FalseHoverFill: gblAppColors.GrayDark,
        Fill: gblAppColors.White,
        FocusedBorderColor: Transparent,
        FocusedBorderThickness: 4,
        Font: Font.'Segoe UI',
        FontWeight: FontWeight.Semibold,
        HandleActiveFill: gblAppColors.White,
        HandleFill: gblAppColors.White,
        HandleHoverFill: gblAppColors.White,
        Height: 40,
        HoverBorderColor: ColorFade(gblAppColors.Primary1, -30%),
        HoverColor: gblAppColors.White,
        HoverDateFill: gblAppColors.GrayMedium,
        HoverFill: ColorFade(gblAppColors.Primary1, -10%),
        IconBackground: gblAppColors.Primary1,
        PaddingBottom: 5,
        PaddingLeft: 12,
        PaddingRight: 5,
        PaddingTop: 5,
        PressedBorderColor: gblAppColors.Primary1,
        PressedColor: gblAppColors.White,
        PressedFill: ColorFade(gblAppColors.Primary1, -30%),
        RadioBorderColor: gblAppColors.Primary1,
        RadioSelectionFill: gblAppColors.Primary1,
        RadiusBottomLeft: 0,
        RadiusBottomRight: 0,
        RadiusTopLeft: 0,
        RadiusTopRight: 0,
        RailFill: gblAppColors.GrayMedium,
        RailHoverFill: ColorFade(gblAppColors.Primary1, 80%),
        RatingFill: gblAppColors.Primary2,
        SelectedDateFill: gblAppColors.Primary1,
        SelectionFill: gblAppColors.Primary1,
        Size: gblAppFonts.Size.Regular,
        TrueFill: gblAppColors.Primary1,
        TrueHoverFill: ColorFade(gblAppColors.Primary1, -30%),
        ValueFill: gblAppColors.GrayMediumDark,
        ValueHoverFill: gblAppColors.Primary1
    }
);