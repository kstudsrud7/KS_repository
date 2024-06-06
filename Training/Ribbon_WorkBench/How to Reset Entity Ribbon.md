[Training/How to Create MD.md](https://crmtipoftheday.com/58/reset-the-command-bar/)

Export out Entity Before Editing Buttons

1. Create a solution that just includes the entity with the button that isn’t working correctly and export from CRM.
2. Extract the customization zip file.
3. Open the customization.xml file in the editor of your choice.
4. Search for RibbonDiff.
5. Replace the entire `<RibbonDiff>` section with the following:

```
<RibbonDiffXml>
  <CustomActions />
  <Templates>
    <RibbonTemplates Id="Mscrm.Templates"></RibbonTemplates>
  </Templates>
  <CommandDefinitions />
  <RuleDefinitions>
    <TabDisplayRules />
    <DisplayRules />
    <EnableRules />
  </RuleDefinitions>
  <LocLabels />
</RibbonDiffXml>
```
