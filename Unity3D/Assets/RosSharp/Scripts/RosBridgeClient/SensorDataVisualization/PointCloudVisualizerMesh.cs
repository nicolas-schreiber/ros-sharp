/*
© Siemens AG, 2018-2019
Author: Berkay Alp Cakal (berkay_alp.cakal.ct@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class PointCloudVisualizerMesh : PointCloudVisualizer
    {
        public Material material;

        private GameObject PointCloudMesh;
        private Mesh mesh;
        private Vector3[] meshVerticies;
        private Color[] meshVertexColors;
        private bool IsCreated = false;

        private void Create()
        {
            PointCloudMesh = new GameObject("PointCloudMesh");
            PointCloudMesh.transform.parent = null;

            PointCloudMesh.AddComponent<MeshFilter>();
            MeshRenderer meshRenderer = PointCloudMesh.AddComponent<MeshRenderer>();
            meshRenderer.material = material;

            mesh = PointCloudMesh.GetComponent<MeshFilter>().mesh;

            IsCreated = true;
        }

        protected override void Visualize()
        {
            if (!IsCreated)
                Create();
            meshVerticies = new Vector3[Points.Length];
            var meshIndices = new int[Points.Length];
            meshVertexColors = new Color[meshVerticies.Length];

            PointCloudMesh.transform.SetPositionAndRotation(base_transform.position, base_transform.rotation);


            for (int i = 0; i < meshVerticies.Length; i++)
            {
                meshVerticies[i].x = Points[i].x;
                meshVerticies[i].y = Points[i].z;
                meshVerticies[i].z = Points[i].y;
                meshIndices[i] = i;
                meshVertexColors[i] = Color.green;
            }


            Debug.Log("Mesh Updated!");
            
            mesh.Clear();

            mesh.MarkDynamic();
            mesh.vertices = meshVerticies;
            mesh.SetIndices(meshIndices, MeshTopology.Points, 0, false);
            mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 10f);
            mesh.colors = meshVertexColors;
            // mesh.triangles = meshTriangles;
        }

        protected override void DestroyObjects()
        {
            Destroy(PointCloudMesh);
            IsCreated = false;
        }
    }
}