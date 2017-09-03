using System.Collections.Generic;
using UnityEngine;

namespace Hex {
    [RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
    public class HexMesh : MonoBehaviour {

        private Mesh _hexMesh;
        private List<Vector3> _vertices;
        private List<int> _triangles;

        private void Awake() {
            GetComponent<MeshFilter>().mesh = _hexMesh = new Mesh();
            _hexMesh.name = "Hex Mesh";
            _vertices = new List<Vector3>();
            _triangles = new List<int>();
        }

        private void Triangulate(HexCell hexCell) {}

        public void Triangulate(HexCell[] hexCells) {
            _hexMesh.Clear();
            _vertices.Clear();
            _triangles.Clear();

            foreach (var hexCell in hexCells) {
                Triangulate(hexCell);
            }

            _hexMesh.vertices = _vertices.ToArray();
            _hexMesh.triangles = _triangles.ToArray();
            _hexMesh.RecalculateNormals();
        }
    }
}