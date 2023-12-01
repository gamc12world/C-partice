const zlib = require('zlib');

const originalData = 'anishguptaanishgupta4'

// Compress data
zlib.deflate(originalData, (err, compressedData) => {
  if (!err) {
    console.log('Original size:', originalData.length);
    console.log('Compressed size:', compressedData.length);
    console.log('Compression ratio:', (originalData.length / compressedData.length).toFixed(2));
    console.log(compressedData.toString("utf8"))
  } else {
    console.error('Compression error:', err);
  }
});
