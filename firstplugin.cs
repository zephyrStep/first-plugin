using System;

public class firstplugin : MVRScript
{
    public override void Init()
    {
        try
        {
            SuperController.LogMessage($"{nameof(firstplugin)} initialized");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(firstplugin)}.{nameof(Init)}: {e}");
        }
    }

    public void OnEnable()
    {
        try
        {
            SuperController.LogMessage($"{nameof(firstplugin)} enabled");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(firstplugin)}.{nameof(OnEnable)}: {e}");
        }
    }

    public void OnDisable()
    {
        try
        {
            SuperController.LogMessage($"{nameof(firstplugin)} disabled");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(firstplugin)}.{nameof(OnDisable)}: {e}");
        }
    }

    public void OnDestroy()
    {
        try
        {
            SuperController.LogMessage($"{nameof(firstplugin)} destroyed");
        }
        catch (Exception e)
        {
            SuperController.LogError($"{nameof(firstplugin)}.{nameof(OnDestroy)}: {e}");
        }
    }
}
