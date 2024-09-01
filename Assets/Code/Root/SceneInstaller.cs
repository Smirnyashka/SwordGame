using Code.Configs;
using Code.Hero;
using Code.Services.AssetProvider;
using Code.Services.InputService;
using UnityEngine;
using Zenject;

namespace Code.Root
{
    public class SceneInstaller : MonoInstaller
    {
        private IControllable _controllable;
        
        public override void InstallBindings()
        {
            BindConfigs();
            BindServices();
            BindUnits();
        }

        private void BindUnits()
        {
            Container.Bind<CharacterController>().FromComponentInHierarchy().AsSingle();
            Container.Bind<HeroConfig>().AsSingle();
            Container.Bind<IControllable>().To<Movement>().AsSingle();
        }

        private void BindConfigs()
        {
            Container.Bind<AssetPathes>().AsSingle();
        }

        private void BindServices()
        {
            Container.Bind<GameInput>().AsSingle();
            Container.BindInterfacesAndSelfTo<SimpleInput>().AsSingle();
        }
    }
}