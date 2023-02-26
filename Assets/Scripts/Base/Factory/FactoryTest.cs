using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* !Example Classes! */
#if false
namespace Example {
	class ProductTest : ProductBase {
		public override void Initialize(IFactoryInfo info)
		{

		}

		public override void Generated()
		{
			
		}
	}

	class FactoryTest : FactoryWithList {
		[SerializeField] ProductTest product;

		public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent)
		{
			var instance = Instantiate(product.gameObject, pos, rot, parent);       // ����
			var generatedProduct = instance.GetComponent<ProductTest>();            // �R���|�[�l���g�擾

			generatedProduct.Initialize(this);              // ������
			AddToGeneratedList(generatedProduct);       // ���X�g�ɒǉ�

			return generatedProduct;
		}
	}

	class FactoryDictTest : FactoryWithDictionary {
		[SerializeField] ProductTest product;

		public override ProductBase GetProduct(Vector3 pos, Quaternion rot, Transform parent)
		{
			var instance = Instantiate(product.gameObject, pos, rot, parent);
			var generatedProduct = instance.GetComponent<ProductTest>();

			generatedProduct.Initialize(this);
			AddToGeneratedDict(generatedProduct, instance.name);

			return generatedProduct;
		}
	}
}

#endif