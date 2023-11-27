using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class GizmoUtils
{
    public static void DrawPath(IEnumerable<Vector3> path, bool looped = false) =>
        Gizmos.DrawLineStrip(path.ToArray<Vector3>(), looped);

    public static void DrawPath(IEnumerable<Vector2> path, bool looped = false, float zOffset = 0) =>
        DrawPath(path.Select(p => new Vector3(p.x, p.y, zOffset)).ToArray(), looped);
}
