# Generics Quiz — Answers

1. **Problem addressed:** Type safety and code reuse without casts/boxing.
2. **List<string>:** `var names = new List<string>();`
3. **Dictionary parameters:** Two — `TKey`, `TValue`.
4. **Must multiple type parameters match?** False.
5. **Add to List:** `Add(item)`.
6. **Remove from List:** `Remove(item)`, `RemoveAt(index)` (also `Clear`, `RemoveAll`).
7. **Indicate generic parameter:** `class Foo<T> {}` using `<T>` after the type name.
8. **Only one type parameter?** False.
9. **Constraints limit usable types?** True.
10. **Constraints allow member access of constraint?** True (e.g., `where T : Stream`).