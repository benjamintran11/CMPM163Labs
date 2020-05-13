Shader "Unlit/NewUnlitShader"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
            };

            sampler2D _MainTex;
            float4 _MainTex_ST;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            #define S(v) smoothstep( 0., 30./R.y, v )     // antialiased clamp
            #define mod(x,y) (x-y*floor(x/y))

            fixed4 frag (v2f i) : SV_Target
            {
                
		    float2 R = i.uv.xy,
		         U = ( mul(2.,(i.uv/50) - R) ) / R.y;
		    float l = mul(10.,length(U)) + mul(.3,_Time.y);
		    
		    float O = U.x < 0. 
		        ? float4( int(l) % 2, int(l) % 2, int(l) % 2, int(l) % 2 )                         // left: brutal mod
		        : float4( S( .5- abs( mod(l-.5, 2.) - 1.) ), S( .5- abs( mod(l-.5, 2.) - 1.) ), S( .5- abs( mod(l-.5, 2.) - 1.) ), S( .5- abs( mod(l-.5, 2.) - 1.) ) ); // right: smooth mod
		          
		    if (i.uv.x-.5==floor(R.x/2.) ) O = float4(1,0,0,0);     // red separator
		    return O = sqrt(O);                                  // sRGB conversion
			}

			// To obtain: (indeed, a smooth version of it)
			//       _    _
			//    ..| |..| |..
			//    __| |__| |__

			// Arrange a chainsaw function like this:
			//    ../\../\..
			//    \/  \/  \/

			// then smoothstep(-eps,eps) it. AA: eps = pixel size

            ENDCG
        }
    }
}
