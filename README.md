# Coimbra Framework

[![openupm](https://img.shields.io/npm/v/com.coimbrastudios.core?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.coimbrastudios.core/)

Package of general utilities to be used with Unity development.

## Known Issues

- Source generators on 2020.3 don't run on the first time you open the editor after deleting the `Library`. Restarting the editor fixes the issue.

## List of Content

- `Actor`: meant to be used as the main script for any `GameObject`, as if we were extending the `GameObject` class itself. See also the `ActorComponentBase` to properly initialize components that requires an `Actor`.
- `Addressables` Helpers: some extra types to make working with it even easier.
    - `AssetReferenceComponentRestriction`: filters any `AssetReference` to only show `GameObject` with the specified components.
    - `AssetReferenceScene`: `AssetReference` that only accepts `SceneAsset` objects.
- Assets Assembly Creator: use `Tools/Coimbra Framework/Create Assets Assembly` menu item to generate assemblies for all scripts in the `Assets` folder.
- `CopyBaseConstructorsAttribute`: quick create types with the same constructors as their parent.
- Decorator Attributes: decorator attributes fully compatible with Unity's standard workflow:
    - `Disable`: disables a field so that it can't be edited. There is also `OnEditMode` and `OnPlayMode` versions.
    - `Indent`: indents a field by the amount of steps specified.
    - `MessageBox`: displays a message above a field. There is also `OnEditMode` and `OnPlayMode` versions.
- Editor Startup Scene: easy way to always load a specific scene when going to play inside the editor This can be configured in `Project Settings/Coimbra Framework`.
- Editor Tools: general utilities under `Tools/Coimbra Framework` menu.
- `FormerlySerializedAsBackingFieldOfAttribute`: `FormerlySerializedAs` subclass that correctly formats the input to `<{propertyName}>k__BackingField`.
- `GameObjectPool`: specialized pooling implementation for `GameObject` with auto resizing functionality.
- Int/Float Ranges: `IntRange` and `FloatRange` to be used instead of `Vector2` and `Vector2Int` when requiring a min and a max value.
- Interface Fields: with `ManagedField` you can expose a field to reference an interface, accepting anything that implements it. Combine it with `TypeFilterAttribute` to better control which objects can be referenced.
- Listeners: components to be used to listen for common events:
    - `AnimatorIKListener`: depends on `Animator`.
    - `AnimatorMoveListener`: depends on `Animator`.
    - `BecameInvisibleListener`: depends on `Renderer`.
    - `BecameVisibleListener`: depends on `Renderer`.
    - `BeforeTransformParentChangedListener`: just a wrapper for `OnBeforeTransformParentChanged` callback.
    - `CanvasGroupChangedListener`: just a wrapper for `OnCanvasGroupChanged` callback.
    - `CanvasHierarchyChangedListener`: just a wrapper for `OnCanvasHierarchyChanged` callback.
    - `Collider2DParticleCollisionListener`: depends on `Collider2D`.
    - `ColliderOverlap2DListener`: custom trigger enter/exit implementation that uses [Collider2D.OverlapCollider](https://docs.unity3d.com/ScriptReference/Collider2D.OverlapCollider.html).
    - `ColliderParticleCollisionListener`: depends on `Collider`.
    - Collision Enter/Exit/Stay 2D Listener: depends on `Collider2D`.
    - Collision Enter/Exit/Stay Listener: depends on `Collider`.
    - `ControllerColliderHitListener`: depends on `CharacterController`.
    - `JointBreak2DListener`: depends on `Joint2D`.
    - `JointBreakListener`: depends on `Joint`.
    - `PlayerLoopEventListener`: depends `IPlayerLoopService` and is a more efficient way to register to update calls.
    - `ParticleSystemParticleCollisionListener`: depends on `ParticleSystem`.
    - `ParticleSystemStoppedListener`: depends on `ParticleSystem`.
    - `ParticleTriggerListener`: depends on `ParticleSystem`.
    - `ParticleUpdateJobScheduledListener`: depends on `ParticleSystem`.
    - `PostRenderListener`: depends on `Camera`.
    - `PreCullListener`: depends on `Camera`.
    - `PreRenderListener`: depends on `Camera`.
    - `RectTransformDimensionsChangeListener`: depends on `RectTransform`.
    - `RenderImageListener`: depends on `Camera`.
    - `RenderObjectListener`: just a wrapper for `OnRenderObject` callback.
    - `RigidbodyOverlap2DListener`: custom trigger enter/exit implementation that uses [Rigidbody2D.OverlapCollider](https://docs.unity3d.com/ScriptReference/Rigidbody2D.OverlapCollider.html).
    - `StartListener`: it also triggers correctly late-listeners.
    - `TransformChangedListener`: manages the [Transform.hasChanged](https://docs.unity3d.com/ScriptReference/Transform-hasChanged.html) property.
    - `TransformChildrenChangedListener`: just a wrapper for `OnTransformChildrenChanged` callback.
    - `TransformParentChangedListener`: just a wrapper for `OnTransformParentChanged` callback.
    - Trigger Enter/Exit/Stay 2D Listener: depends on `Collider2D`.
    - Trigger Enter/Exit/Stay Listener: depends on `Collider`.
    - `WillRenderObjectListener`: depends on `Renderer`.
- Object Pooling: use `ManagedPoolT<T>` for pooling any managed objects. It also comes with a few `SharedManagedPool` implementations that can be inspected at `Window/Coimbra Framework/Shared Managed Pools`:
    - `DictionaryPool`: clears the `Dictionary`.
    - `GUIContentPool`: clears the `GUIContet`.
    - `HashSetPool`: : clears the `HashSet`.
    - `ListPool`: clears the `List`.
    - `ManagedPool`: allows custom clearing through the `IManagedPoolHandler` interface.
    - `QueuePool`: clears the `Queue`.
    - `StackPool`: clears the `Stack`.
    - `StringBuilderPool`: clears the `StringBuilder`.
- Property Attributes: property attributes fully compatible with Unity's standard workflow:
    - `AnimatorParameter`: draws a parameter selector for a given animator.
    - `AssetsOnly`: prevents to assign a scene object to a `UnityEngine.Object` field.
    - `EnumFlags`: turns an enum field into a enum mask popup field.
    - `IntRange`: draws a property as if it was a `IntRange`.
    - `FloatRange`: draws a property as if it was a `FloatRange`.
    - `LayerSelector`: turns an int field into a layer popup field.
    - `NotGreaterThan`: prevents an int field to have a value greater than the a given value.
    - `NotLessThan`: prevents an int field to have a value smaller than the a given value.
    - `RangeSlider`: draws a property using the Unity's `MinMaxSlider`.
    - `SortingLayerID`: turns an int field into a sorting layer popup field.
    - `TagSelector`: turns a string field into a tag popup field.
    - `TypeDropdownAttribute`: use in combination with `SerializeReferenceAttribute` to expose a type selector. Can also be combined with `TypeFilterAttribute`.
    - `Validate`: calls a method `void()` or `void(T previous)` when the property is changed. It is also the base for all others attributes.
- `PropertyPathInfo`: reflection helper class for any `SerializeField` based on its [propertyPath](https://docs.unity3d.com/ScriptReference/SerializedProperty-propertyPath.html).
- `Reference<T>`: create a `Reference` for any value or even another reference.
- `ScriptableSettings`: easily access a `ScriptableObject` from anywhere with option to preload those on the application startup. You can also make them appear in the project settings with `ProjectSettingsAttribute` or in the preferences
  with `PreferencesAttribute`. You can see all the currently loaded `ScriptableSettings` in `Window/Coimbra Framework/Scriptable Settings`;
- `SerializableDictionary`: supports modifying and saving through the inspector. Can have its size locked with `DisableResizeAttribute` or made read-only with `DisableAttribute`.
- `SerializableType<T>`: serializes a `System.Type` that can be edited and saved from the inspector.
- `ServiceLocator`: enable a service-based architecture easily. You can check all the created `ServiceLocator` at `Window/Coimbra Framework/Service Locator`. It also comes with a few built-in functionalities:
    - Attributes:
        - `AbstractServiceAttribute`: by default, any interface implementing `IService` is considered a valid service type. Use this attribute to create interfaces that should not be considered a valid service type besides implementing `IService`.
        - `DisableDefaultFactoryAttribute`: by default, a factory is set for each new compatible type during `SubsystemRegistration`. You can disable that per-implementation by using this attribute.
        - `DynamicServiceAttribute`: by default, once a `IService` is set it can't be overriden. You can disable that by using that attribute, allowing to have temporary services (like per-scene).
        - `HideInServiceLocatorWindowAttribute`: by default, all services will appear in the `Service Locator` window, even test ones. Use this attribute to hide unwanted services.
        - `PreloadServiceAttribute`: add this in your `IService` implementation to call the `ServiceLocator.Get` during `BeforeSceneLoad`. This is just to reduce common boilerplate code.
    - Services:
        - `IApplicationStateService`: responsible for some built-in events:
            - `ApplicationFocusEvent`
            - `ApplicationPauseEvent`
            - `ApplicationQuitEvent`
        - `ICoroutineService`: start or stop a Unity `Coroutine` from anywhere.
        - `IEventService`: listen and invoke strongly-typed events.
        - `IPlayerLoopService`: responsible for [PlayerLoop](https://docs.unity3d.com/ScriptReference/LowLevel.PlayerLoop.html)-related events:
            - `FixedUpdateEvent`
            - `LateUpdateEvent`
            - `UpdateEvent`
            - [PlayerLoopTiming](https://github.com/Cysharp/UniTask#playerloop) Events
        - `IPoolingService`: leverages `GameObjectPool` by making those easily accessible from anywhere.
        - `ITimerService`: start or stop timers from anywhere with the same precision as `Invoke` and `InvokeRepeating`.
- Utilities & Extensions: check if a `GameObject` `IsPersistent`, `Destroy` any Unity `Object` safely, fake-cast a `GameObject` to `Actor`, use `?.` and `??` safely wth any Unity `Object`, and much more.

## Dependencies

- UniTask: https://github.com/Cysharp/UniTask

## Analyzers

| ID          | Title                                                                                                 | Severity | Code Fix |
|-------------|:------------------------------------------------------------------------------------------------------|----------|----------|
| COIMBRA0001 | Concrete IEvent should be partial.                                                                    | Warning  | Yes      |
| COIMBRA0002 | Concrete IEvent should not be a nested type.                                                          | Error    | Yes      |
| COIMBRA0003 | Class events should be either abstract or sealed.                                                     | Error    | No       |
| COIMBRA0004 | ServiceLocator APIs requires an interface type as generic parameter.                                  | Error    | No       |
| COIMBRA0005 | ServiceLocator APIs requires an interface type without AbstractServiceAttribute as generic parameter. | Error    | No       |
| COIMBRA0006 | Concrete IService should only implement one IService at a time.                                       | Error    | No       |
| COIMBRA0007 | Concrete IService should not implement any IService with AbstractServiceAttribute.                    | Warning  | No       |
| COIMBRA0008 | Type with SharedManagedPoolAttribute should not be generic.                                           | Error    | No       |
| COIMBRA0009 | IEventService generic APIs should not be used directly.                                               | Error    | No       |
| COIMBRA0010 | Type can't implement any IService because parent class already implements one.                        | Error    | No       |
| COIMBRA0011 | Concrete IService should not be a Component unless it inherit from Actor.                             | Warning  | No       |
| COIMBRA0012 | A ScriptableSettings should not implement any IService.                                               | Error    | No       |
| COIMBRA0013 | ProjectSettingsAttribute and PreferencesAttribute should not be used together.                        | Error    | No       |
| COIMBRA0014 | ScriptableSettings has an invalided FileDirectory.                                                    | Error    | No       |
| COIMBRA0015 | ScriptableSettings attributes are not supported on abstract types.                                    | Error    | No       |
| COIMBRA0016 | ScriptableSettings attributes are not supported on generic types.                                     | Error    | No       |
| COIMBRA0017 | Use CreateShared method for any SharedManagedPool.                                                    | Error    | No       |
| COIMBRA0018 | Use constructor when not a SharedManagedPool.                                                         | Error    | No       |
| COIMBRA0019 | Object.Destroy should not be used with Objects that can be an Actor.                                  | Warning  | No       |
| COIMBRA0020 | Type with CopyBaseConstructorsAttribute should be partial.                                            | Warning  | Yes      |
| COIMBRA0021 | Type with CopyBaseConstructorsAttribute should not be nested.                                         | Error    | Yes      |
| COIMBRA0022 | Type with SharedManagedPoolAttribute should be partial.                                               | Warning  | Yes      |
| COIMBRA0023 | Type with SharedManagedPoolAttribute should not be nested.                                            | Error    | Yes      |
