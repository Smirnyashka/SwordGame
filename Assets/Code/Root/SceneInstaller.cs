﻿using Code.Configs;
using Code.Services.AssetProvider;
using Code.Services.InputService;
using UnityEngine;
using Zenject;

namespace Code.Root
{
    public class SceneInstaller : MonoInstaller
    {

        [SerializeField] private HeroConfig _config;
        [SerializeField] private PlaceConfig _placeConfig;

        [SerializeField] private int count;

        public override void InstallBindings()
        {
            BindConfigs();
            BindServices();
        }

        private void BindConfigs()
        {
            Container.Bind<PlaceConfig>().FromInstance(_placeConfig).AsSingle();
            Container.Bind<HeroConfig>().AsSingle();
            Container.Bind<AssetPathes>().AsSingle();
        }

        private void BindServices()
        {
            Container.Bind<IInput>().To<SimpleInput>().AsSingle();
            // Container.Bind<CubePool>().AsSingle();
            // Container.Bind<PoolMono<Cube>>().AsSingle().WithArguments(count, transform);
        }
    }
}