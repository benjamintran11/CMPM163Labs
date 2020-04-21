//fragment shader outputs the pixel color for the fragment we are shading.
//fragments are triangles -> forms 3d shapes (includes color/shading).

varying vec3 vUv;

uniform vec3 colorA;
uniform vec3 colorB;


void main() {
	gl_FragColor = vec4(mix(colorA, colorB, vUv.z), 1.0);
}