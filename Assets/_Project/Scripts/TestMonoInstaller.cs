using _Project.Scripts;
using UnityEngine;
using Zenject;

public class TestMonoInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<ISelectionEffect>().To<SelectionEffect_size>().AsSingle();
        Container.Bind<ISelectionEffect>().To<SelectionEffect_Color>().AsSingle().When(IsColor);
        
    }

    private bool IsColor(InjectContext _injectContext)
    {
        var test = _injectContext.ObjectInstance as SelectionDetector_NoSolid;
        return test!=null && test.m_isColor;
    }
}