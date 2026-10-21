const XLSX = require('xlsx');

const workbook = XLSX.readFile('/Users/wagnercruz/workspace/conectacirurgica/docs/Mapa 2110.xlsx');
const sheetName = workbook.SheetNames[0];
const worksheet = workbook.Sheets[sheetName];

console.log("Range:", worksheet['!ref']);
const jsonData = XLSX.utils.sheet_to_json(worksheet, { defval: '', header: 1 });

if (jsonData.length > 0) {
  console.log('Row 0 (Headers if not using header:1):', jsonData[0]);
  console.log('Row 1 (Data):', jsonData[1]);
  console.log('Row 2 (Data):', jsonData[2]);
}
