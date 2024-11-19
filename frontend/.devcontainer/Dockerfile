# Use the official Node.js image as the base image
FROM node:14

# Set the working directory
WORKDIR /workspace

# Install pnpm
RUN npm install -g pnpm

# Copy the project files into the container
COPY . .

# Install project dependencies
RUN pnpm install

# Set up the environment for the development container
ENV PATH /workspace/node_modules/.bin:$PATH

# Install additional tools and dependencies
RUN apt-get update && apt-get install -y \
    git \
    curl \
    && rm -rf /var/lib/apt/lists/*

# Set the default shell to bash
SHELL ["/bin/bash", "-c"]

# Set the default command to start the development container
CMD ["pnpm", "start"]
