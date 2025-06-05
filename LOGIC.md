# �[�c�`���]MVC �Ѧҡ^

�A���M�ױĥ����� MVC�]Model-View-Controller�^�[�c�A�D�n�����T�Ӽh���G

## 1. Model�]��Ƽҫ��h�^

- **��m**�G`Repository\ProductDetails\*`  
- **���e**�G
  - �t�d��Ƶ��c���w�q�A�Ҧp�G
    - �ӫ~�]`Product`�^
    - �����]`Category`�^
    - ����]`ProductPrice`�^
    - �w�s�]`Inventory`�^
    - �����ӡ]`Supplier`�^
    - �i�f�]`Purchase`�^
    - �P��]`Sale`, `SaleDetail`�^
  - �C�����O���ʸˤF�������ݩʻP�غc���A�M�`���ƥ������y�z�P�x�s�C

## 2. Controller�]�����޿�h�^

- **��m**�G`Controller\*`  
- **���e**�G
  - �Ҧp `Config` ���O�A�t�d���ε{���]�w�P��Ƹ��|�޲z�C
  - ����h�t�d��� Model �P View ���������ʡA�B�z�~���޿�P��Ƭy�C

## 3. View�]��ı�Ƥ����h�^

- **��m**�G`UI\*`  
- **���e**�G
  - �]�t�h�Ӫ��]Form�^�A�p�G
    - `Desingener`
    - `AddSupplierForm`
    - `AddProductData`
    - `ReceivingForm`
  - �o�Ǫ��t�d�P�ϥΪ̤��ʡA��ܸ�ƨñ�����J�C
  - �D�n�H WinForms/WPF ����¦�A�z�L�ƥ�]�p���s�I���^Ĳ�o Controller ���޿�C

---

# �[�c���ʬy�{²�z

1. **�ϥΪ̾ާ@�����]View�^**�G  
   �Ҧp�b `Desingener` �D����I���u�i�f�v�B�u�P��v�B�u�w�s�v�����s�C

2. **Ĳ�o�����޿�]Controller�^**�G  
   �ƥ�B�z�禡�]�p `BtnPurchase_Click`�^�|�I�s Controller �h���޿�A�i���ƳB�z�Φs���C

3. **��Ʀs���P�B�z�]Model�^**�G  
   Controller �|�ާ@ Model �h������A�i���ƪ��s�W�B�d�ߡB�ק�B�R�����ާ@�C

4. **���G�^�X�ܤ����]View�^**�G  
   �B�z���G�|�^�ǵ� View�A��s�e������ܰT�����ϥΪ̡C

# ��ƼҲճW��

![��ƼҲճW��](������ۤ�.png)
