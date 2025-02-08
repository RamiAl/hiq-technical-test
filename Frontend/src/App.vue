<template>
  <div>
    <h1>Upload text file</h1>
    <form @submit.prevent="uploadFile">
      <input type="file" @change="onFileChange" accept=".txt, .rtf, .md, .file" />
      <button type="submit">Upload</button>
    </form>

    <div v-if="processedText">
      <h2>Processed Text</h2>
      <pre>{{ processedText }}</pre>
    </div>
  </div>
</template>

<script>
import axios from 'axios';

export default {
  name: 'App',
  data() {
    return {
      selectedFile: null,
      processedText: ''
    };
  },
  methods: {
    onFileChange(event) {
      this.selectedFile = event.target.files[0];
    },
    async uploadFile() {
      if (!this.selectedFile) {
        alert('Please select a file first.');
        return;
      }
      try {
        const formData = new FormData();
        formData.append('file', this.selectedFile);

        const response = await axios.post(
          `${import.meta.env.VITE_API_URL}/upload/file`, 
          formData,
          {
            headers: {
              'Content-Type': 'multipart/form-data'
            }
          }
        );

        this.processedText = response.data.processedText;
      } catch (error) {
        console.error(error);
        alert('An error occurred while uploading file.');
      }
    }
  }
};
</script>
