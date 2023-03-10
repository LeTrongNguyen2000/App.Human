using Volo.Abp.Settings;

namespace App.Human.Settings;

public class HumanSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HumanSettings.MySetting1));
    }
}
