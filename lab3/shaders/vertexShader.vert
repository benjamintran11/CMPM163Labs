//Note: vertex shader runs for ever vertex of a mesh of a geometry

varying vec3 vUv;

void main() { 
	vUv = position; 

	vec4 modelViewPosition = modelViewMatrix * vec4(position, 1.0); //maintains position of vertices of mesh for cube stays intact
	gl_Position = projectionMatrix * modelViewPosition;
}


