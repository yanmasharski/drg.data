# Known Issues — drg.data

> Code review: 2026-05-27. Ordered by severity.

## Compile blockers

- [ ] Fix `DataStorage.ProcessAndSave` — remove `yield return` inside `lock` (CS1631) (`DataStorage.cs:171-195`)

## Critical

- [ ] Fix `DataRecordObject.SetValue` NRE when both old and new value are null (`DataRecordObject.cs:32`)
- [ ] Fix `DataRecordObject.Apply` — no unsynchronized `Task.Run`, main-thread `PlayerPrefs`, surface errors (`DataRecordObject.cs:49-61`)

## Major

- [ ] Apply consistent locking in `DataStorage` (`ContainsKey`, `EraseAll`, `GetEnumerator`) (`DataStorage.cs`)
