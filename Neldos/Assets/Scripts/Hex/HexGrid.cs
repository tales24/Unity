using UnityEngine;

namespace Hex {
    public class HexGrid : MonoBehaviour {
        public int Width = 6;
        public int Height = 6;

        public HexCell HexCellPrefab;

        private HexCell[] _hexCells;
        private HexMesh _hexMesh;

        private void Awake() {
            _hexMesh = GetComponentInChildren<HexMesh>();
            _hexCells = new HexCell[Height * Width];

            for (int z = 0, i = 0; z < Height; z++) {
                for (var x = 0; x < Width; x++) {
                    CreateCell(x, z, i++);
                }
            }
        }

        private void Start() {
            _hexMesh.Triangulate(_hexCells);
        }

        private void CreateCell(int x, int z, int i) {
            Vector3 position;
            position.x = (x + z * 0.5f - z / 2) * HexMetrics.InnerRadius * 2.0f;
            position.y = 0.0f;
            position.z = z * HexMetrics.InnerRadius * 1.5f;

            var cell = _hexCells[i] = Instantiate<HexCell>(HexCellPrefab);
            cell.transform.SetParent(transform, false);
            cell.transform.localPosition = position;
        }
    }
}
