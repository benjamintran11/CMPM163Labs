//Note: vertex shader runs for ever vertex of a mesh of a geometry

varying vec2 vUv;

void main() {
	vUv = uv;
	vec4 modelViewPosition = modelViewMatrix * vec4(position, 
	1.0);
	gl_Position = projectionMatrix * modelViewPosition;
}
