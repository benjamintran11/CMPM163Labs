//fragment shader outputs the pixel color for the fragment we are shading.
//fragments are triangles -> forms 3d shapes (includes color/shading).

uniform sampler2D texture1;
varying vec2 vUv;

void main() {
vec2 scaleUV = vUv * 2.0;
scaleUV = mod(scaleUV, 1.0); 
gl_FragColor =  texture2D(texture1, scaleUV); //rgba
}
