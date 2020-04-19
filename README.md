# ImpostoDeRenda

Este repositório contém um programa com o objetivo de calcular o imposto de renda para um determinado salário. As regras estão representadas abaixo.

<table>
  <thead>
    <th>Faixa de Renda</th>
    <th>Imposto de renda (%)</th>
  </thead>
  <tbody>
    <tr>
    	<td>de 0.00 a R$ 2000.00</td>
			<td>Isento</td>
    </tr>
		<tr>
    	<td>de R$ 2000.01 até R$ 3000.00</td>
			<td>8</td>
    </tr>
		<tr>
    	<td>de R$ 3000.01 até R$ 4500.00</td>
			<td>18</td>
    </tr>
		<tr>
    	<td>Acima de R$ 4500.00</td>
			<td>28</td>
    </tr>
  <tbody>
</table>

Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda.Neste caso a taxa é
de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. 
