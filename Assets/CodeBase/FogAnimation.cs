using System.Collections;
using UnityEngine;

namespace CodeBase
{
    public class FogAnimation : MonoBehaviour
    {
        public float speed = 1f;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();

            StartCoroutine(FigTileCoroutine());
        }

        private IEnumerator FigTileCoroutine()
        {
            Vector2 size = _spriteRenderer.size;
            while (true)
            {
                for (float t = 0.0f; t < 600f; t += Time.deltaTime * speed)
                {
                    _spriteRenderer.size = size + new Vector2(t, 0f);

                    yield return null;
                }
            }
        }
    }
}