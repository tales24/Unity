using UnityEngine;

namespace Hex {
    public static class HexMetrics {
        public const float OuterRadius = 1.0f;
        public const float InnerRadius = OuterRadius * 0.866025404f;

        public static Vector3[] Corners = {
            new Vector3(0.0f, 0.0f, OuterRadius),
            new Vector3(InnerRadius, 0.0f, 0.5f * OuterRadius),
            new Vector3(InnerRadius, 0.0f, -0.5f * OuterRadius),
            new Vector3(0.0f, 0.0f, -OuterRadius),
            new Vector3(-InnerRadius, 0.0f, -0.5f * OuterRadius),
            new Vector3(-InnerRadius, 0.0f, 0.5f * OuterRadius)
        };
    }
}
