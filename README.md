# DRG Data

Persistent data storage with PlayerPrefs backend, typed records, and pluggable serialization.

## Assemblies

| Assembly | Contains |
|---|---|
| `DRG.Data` | `IDataStorage`, `IDataRecord`, `ITypedDataRecord<T>`, `IDataProvider`, `DRG.Data.Serialization.IDataSerializer` |
| `DRG.Data.Runtime` | `DataStorage`, `DataProviderPlayerPrefs`, `DataRecord{Bool,Int,Float,String,Object}`, `DataSerializerUnity` |

## Key types

- **`IDataStorage`** — typed getters (`GetBool`, `GetInt`, `GetFloat`, `GetString`, `GetObject<T>`), `Erase`, `Save`.
- **`ITypedDataRecord<T>`** — value container: read `value`, write `value = x`. Changes are tracked until `Save()`.
- **`DataStorage`** — in-memory store backed by an `IDataProvider`. Debounced `Save()` flushes to the provider.
- **`DataProviderPlayerPrefs`** — `IDataProvider` backed by Unity `PlayerPrefs`.
- **`DataSerializerUnity`** — `IDataSerializer` using `UnityEngine.JsonUtility`.

## Serializer packages

| Package | Serializer |
|---|---|
| `com.drg.data.newtonsoft` | Newtonsoft.Json |

## Usage

```csharp
var storage = new DataStorage(new DataProviderPlayerPrefs(), debouncedExecutor, logger);
var coins = storage.GetInt("coins", defaultVal: 0);
coins.value += 100;
storage.Save();
```

## Dependencies

- `com.drg.core`
- `com.drg.utils`

## Install

```
https://github.com/yanmasharski/drg.data.git#1.0.0
```
